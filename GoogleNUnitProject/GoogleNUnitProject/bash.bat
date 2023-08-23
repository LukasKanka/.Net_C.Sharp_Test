@echo off
dotnet test --logger:"html;LogFilePath=testresults.html;IncludeTestContext=true;Title=true;Description=true"



