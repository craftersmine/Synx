using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.Synx.Server.Core
{
    public sealed class UserStorage
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();

        public UserStorage()
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            users.Clear();
            string[] allUsersUnparsed = File.ReadAllLines(StaticData.AccountsFilePath);
            if (allUsersUnparsed.Length > 0)
                foreach (var ln in allUsersUnparsed)
                {
                    string[] splitted = ln.Split('$');
                    users.Add(splitted[0], new User(splitted[0], splitted[1], long.Parse(splitted[2])));
                }
            else Program.Log("warn", "No registered users found! Add users by call \"user add [username] [password] <allowedQuota>\"");
        }

        public void RegisterUser(string username, string password, long allowedQuota = 0)
        {
            if (!users.ContainsKey(username))
            {
                if (allowedQuota == 0)
                {
                    allowedQuota = ServerConfig.GetLong("user-default-quota");
                    Program.Log("warn", "No storage quota defined for user \"" + username + "\". Setting default value!");
                }
                string encPass = Utils.MD5Compute.ComputeMD5(Utils.MD5Compute.ComputeMD5(password));
                string lineCtor = $"{username}${encPass}${allowedQuota.ToString()}";
                File.AppendAllLines(StaticData.AccountsFilePath, new string[] { lineCtor });
                LoadUsers();
            }
            else Program.Log("info", "User with username \"" + username + "\" already registered!");
        }

        public void RemoveUser(string username)
        {
            if (users.ContainsKey(username))
            {
                users.Remove(username);
                List<string> lns = new List<string>();
                foreach (var user in users)
                {
                    string lineCtor = $"{user.Value.Username}${user.Value.EncryptedPassword}${user.Value.AllowedStorageQuota.ToString()}";
                    lns.Add(lineCtor);
                }
                File.WriteAllLines(StaticData.AccountsFilePath, lns);
                LoadUsers();
                Program.Log("done", "User \"" + username + "\" successfully removed from database!");
            }
            else Program.Log("info", "User with username \"" + username + "\" not found!");
        }

        public string[] ToStringArray()
        {
            List<string> lns = new List<string>();
            foreach (var user in users)
            {
                double quota = user.Value.AllowedStorageQuota;
                string quotaSuff = "Bytes";
                if (quota >= 1024.0d)
                {
                    quota /= 1024.0d;
                    quotaSuff = "KBytes";
                    if (quota >= 1024.0d)
                    {
                        quota /= 1024.0d;
                        quotaSuff = "MBytes";
                        if (quota >= 1024.0d)
                        {
                            quota /= 1024.0d;
                            quotaSuff = "GBytes";
                            if (quota >= 1024.0d)
                            {
                                quota /= 1024.0d;
                                quotaSuff = "TBytes";
                            }
                        }
                    }
                }
                lns.Add(string.Format(@"Username: {0} - Allowed quota: {1:F2} {2}", user.Value.Username , quota, quotaSuff));
            }
            return lns.ToArray();
        }
    }

    public struct User
    {
        public string Username { get; }
        public string EncryptedPassword { get; }
        public long AllowedStorageQuota { get; }

        public User(string username, string encryptedPass, long allowedStorQuota)
        {
            Username = username;
            EncryptedPassword = encryptedPass;
            AllowedStorageQuota = allowedStorQuota;
        }
    }
}
