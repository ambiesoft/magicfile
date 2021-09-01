
setlocal
set PROJECTNAME=magicfile
C:\local\python3\python.exe ..\distSolution\distSolution.py --show-dummygitrev-csharp > "%~dp0%PROJECTNAME%\gitrev.cs"

pause