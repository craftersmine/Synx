@echo off
echo Cleaning up...
del packed /S /Q
mkdir packed
echo Building resources... Locales
"utils\cmpkgrcmd.exe" --pack --pkgname="ru" --files="sources\locales\ru\form.main.strings";"sources\locales\ru\form.connectTo.strings";"sources\locales\ru\common.strings";"sources\locales\ru\form.authorize.strings";"sources\locales\ru\form.logs.strings" --outdir="packed\locales"
echo Building resources... Icons
"utils\cmpkgrcmd.exe" --pack --pkgname="logs" --files="sources\icons\logs\info.png";"sources\icons\logs\error.png";"sources\icons\logs\warning.png";"sources\icons\logs\done.png";"sources\icons\logs\critical.png";"sources\icons\logs\stacktrace.png";"sources\icons\logs\connection.png";"sources\icons\logs\success.png";"sources\icons\logs\debug.png";"sources\icons\logs\crash.png";"sources\icons\logs\unknown.png" --outdir="packed\icons"
echo Renaming packages...
rename .\packed\locales\ru.cmpkg ru.pak
rename .\packed\icons\logs.cmpkg logs.pak
echo Building resources... Done
pause