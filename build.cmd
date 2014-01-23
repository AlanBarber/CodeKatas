@echo off
@echo ************************
@echo Updating NuGet packages...
@echo ************************
".nuget\nuget.exe" install .nuget\packages.config -o lib
@echo.
@echo ************************
@echo Building Documentation...
@echo ************************
for %%i in (docs\*.md) do (
	@echo %%i
	lib\md2html\md2html.exe %%i
	)

@echo.
@echo ************************
@echo Building Project...
@echo ************************

@echo.
@echo ************************
@echo Build Complete!
@echo ************************