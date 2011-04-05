@ECHO OFF

IF NOT EXIST BIN MKDIR bin
ATTRIB BIN\*.* -S -H -R /S > NUL
ATTRIB BIN\*.* -S -H -R /S /D > NUL
IF EXIST BIN\*.LOG DEL BIN\*.LOG > NUL

REM ----------------------------
REM Visual Studio 2005 Solutions
REM ----------------------------

SETLOCAL
@SET VSIDE="%VS80COMNTOOLS%..\IDE\DEVENV"

REM >> ZUKI.DATA
%VSIDE% /OUT bin\data.log /REBUILD "%1|Win32" SRC\DATA\DATA.SLN
%VSIDE% /OUT bin\data.log /REBUILD "%1|x64" SRC\DATA\DATA.SLN

REM >> ZUKI.WEB
%VSIDE% /OUT bin\web.log /REBUILD "%1|Win32" SRC\WEB\WEB.SLN
%VSIDE% /OUT bin\web.log /REBUILD "%1|x64" SRC\WEB\WEB.SLN

REM >> TOOLS
%VSIDE% /OUT bin\tools.log /REBUILD "%1|Win32" SRC\TOOLS\TOOLS.SLN
%VSIDE% /OUT bin\tools.log /REBUILD "%1|x64" SRC\TOOLS\TOOLS.SLN

REM >> SETUP
%VSIDE% /OUT bin\setup.log /REBUILD "%1" SRC\SETUP\SETUP.SLN

ENDLOCAL


PAUSE