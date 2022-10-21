@ECHO OFF
ECHO Demo Automation Executed Started.


set testcategory=LoginPage
set dllpath=C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug\
set trxerpath=C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug\
set SummaryReportPath=C:\Users\Admin\source\repos\ScratchF\sum

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  C:\Users\Admin\source\repos\ScratchF\ScratchF\bin\Debug\ScratchF.dll
TestCaseFilter:"TestCategory=%testcategory%" /Logger:"trx;LogFileName=C:\Users\Admin\source\repos\ScratchF\sum\%filename%.trx"

cd %trxerpath%

TrxToHTML %SummaryReportPath%\%filename%\

PAUSE