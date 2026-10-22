@echo off
REM Publish for Windows x64, including the .NET runtime for the target computer.
cd /d "%~dp0"
dotnet publish "Soldier Financial Management System.csproj" -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o publish
pause
