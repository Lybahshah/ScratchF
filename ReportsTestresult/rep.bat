@ECHO OFF
ECHO Demo Automation Executed Started.


set testcategory=Smoke
set dllpath=C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug\ScratchF.dll
set trxerpath=C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug
set SummaryReportPath=C:\Users\Admin\source\repos\ScratchF\sum



call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe %dllpath% /TestCaseFilter:"TestCategory=%testcategory%" /Logger:"trx;LogFileName=%SummaryReportPath%\report.trx"


cd %trxerpath%

TrxToHTML %SummaryReportPath%

PAUSE