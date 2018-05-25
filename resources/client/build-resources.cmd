@echo off
echo Cleaning up...
del packed /S /Q
mkdir packed
echo Building resources... Locales
"utils\cmpkgrcmd.exe" --pack --pkgname="ru" --files="sources\locales\ru\form.main.strings";"sources\locales\ru\form.connectTo.strings";"sources\locales\ru\common.strings" --outdir="packed\locales"
echo Renaming packages...
rename .\packed\locales\ru.cmpkg ru.pak
echo Building resources... Done
pause