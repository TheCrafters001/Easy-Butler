echo off
color f
mode 103,5
set counter=0
set counterb=000
set core=����������������������������������������������������������������������������������������������������
set "valuecore=                                                                                                    "
setLocal EnableDelayedExpansion
:start
cls
echo.����������������������������������������������������������������������������������������������������Ļ
echo.�%valuecore:~0,100%�
echo.����������������������������������������������������������������������������������������������������ļ
if %counter% GEQ 100 set msg=complete& set counterb=10000& goto exit
echo. %counterb:~0,-2%%%
set /a counter=counter+5
set /a counterb=counterb+500
set "valuecore=!core:~0,%counter%!                                                                                                    "
set delay=0
:delay
if %delay%==50 goto start
set /a delay=delay+1
goto delay
:exit
echo. %counterb:~0,-2%%% %msg%
ENDLOCAL
pause >NUL
