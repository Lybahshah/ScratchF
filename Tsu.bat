@ECHO OFF
ECHO Demo Automation Executed Started.



set dllpath=C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug\
set trxerpath=C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug\
set SummaryReportPath=C:\Users\Admin\source\repos\ScratchF\sum\


call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug\ScratchF.dll
/Logger:"trx;LogFileName=C:\Users\Admin\source\repos\ScratchF\TestSummaryreport\LoginPage.trx"

cd %trxerpath%

TrxToHTML.exe %SummaryReportPath%

PAUSE