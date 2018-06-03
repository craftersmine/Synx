using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Synx.Server.Core
{
    public sealed class CommandParser
    {
        private Dictionary<string, Action<string[]>> commands = new Dictionary<string, Action<string[]>>();
        
        public void RegisterCommand(string name, Action<string[]> action)
        {
            commands.Add(name, action);
        }

        public void ParseInput(string input)
        {
            string[] splitted = input.Split(' ');
            if (splitted.Length > 0)
            {
                string commandName = splitted[0].ToLower();
                List<string> args = new List<string>();
                if (splitted.Length > 1)
                    for (int i = 1; i < splitted.Length; i++)
                    {
                        args.Add(splitted[i]);
                    }
                if (commands.ContainsKey(commandName))
                    commands[commandName].Invoke(args.ToArray());
                else Program.Log("warn", "Invalid command \"" + commandName + "\"! Type \"help\" for help");
            }
        }

        public void HelpCommandHelper(string[] contents)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var ln in contents)
            {
                Program.Log("info", ln);
            }
            Console.ResetColor();
        }
    }

    public sealed class CommandRegister
    {
        public static void RegisterCommands()
        {
            StaticData.CommandParser.RegisterCommand("stop", new Action<string[]>((a) => { ServerController.StopServer(); }));
            StaticData.CommandParser.RegisterCommand("user", new Action<string[]>((a) =>
            {
                if (a.Length > 0)
                {
                    switch (a[0].ToLower())
                    {
                        case "add":
                            if (a.Length > 2)
                            {
                                bool isUserCanCreated = true;
                                string usrName = a[1];
                                string pass = a[2];
                                long quota = 0;
                                if (a.Length > 3)
                                {
                                    if (!long.TryParse(a[3], out quota))
                                    { Program.Log("error", "Unable to create user! Quota must be long numerical value!"); isUserCanCreated = false; }
                                }
                                if (isUserCanCreated)
                                    StaticData.UserStorage.RegisterUser(usrName, pass, quota);
                            }
                            else Program.Log("warn", "Invalid syntax! Try type \"user\" to find wanted solution");
                            break;
                        case "dump":
                            File.WriteAllText(StaticData.AccountsFilePath, "");
                            StaticData.UserStorage.LoadUsers();
                            break;
                        case "remove":
                            if (a.Length > 1)
                            {
                                StaticData.UserStorage.RemoveUser(a[1]);
                            }
                            else Program.Log("warn", "Invalid syntax! Try type \"user\" to find wanted solution");
                            break;
                        case "list":
                            string[] lns = StaticData.UserStorage.ToStringArray();
                            if (lns.Length > 0)
                                foreach (var ln in lns)
                                {
                                    Program.Log("info", ln);
                                }
                            else Program.Log("warn", "No registered users found! Add users by call \"user add [username] [password] <allowedQuota>\"");
                            break;
                        default:
                            Program.Log("warn", "Invalid argument \"" + a[0] + "\"! Try type \"user\" to find wanted solution");
                            break;
                    }
                }
                else
                {
                    StaticData.CommandParser.HelpCommandHelper(new string[] { "Allows to manage user database.", "Usages:", " user add [username] [password] <allowedQuota>", " user remove [username]", " user dump", "user list" });
                }
            }));

            StaticData.CommandParser.RegisterCommand("help", new Action<string[]>((a) => {
                if (a.Length > 0)
                {
                    switch (a[0].ToLower())
                    {
                        case "user":
                            StaticData.CommandParser.HelpCommandHelper(new string[] { "Allows to manage user database.", "Usages:", " user add [username] [password] <allowedQuota>", " user remove [username]", " user dump", "user list" });
                            break;
                        default:
                            StaticData.CommandParser.HelpCommandHelper(new string[] { "No command \"" + a[0] + "\" found! Type \"help\" to show all allowed commands" });
                            break;
                    }
                }
                else StaticData.CommandParser.HelpCommandHelper(new string[]
                {
                    "All allowed commands are bellow:",
                    " user - Allows to manage user database.",
                    " stop - Softly stops Synx Server"
                });
            }));
        }
    }
}
