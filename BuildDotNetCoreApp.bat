@echo off
set CURRENT_PATH=%~1
set ROOT_PROJECT_FOLDER=%cd%
set HELPPER_PUBLISH_DEBUG=%ROOT_PROJECT_FOLDER%\Helper\bin\Debug\netcoreapp2.1\publish
set WEB_API_LIB=%ROOT_PROJECT_FOLDER%\WebApi\Lib
set WEB_APP_LIB=%ROOT_PROJECT_FOLDER%\WebApp\Lib
set WEB_APP=%ROOT_PROJECT_FOLDER%\WebApp
echo "Begin  Build DotNet Core App"
echo "**********************************************************************************************************************************************************************"
echo "	1. Go to the root project folder : %ROOT_PROJECT_FOLDER%"
	cd "/d %ROOT_PROJECT_FOLDER%"
echo "	2. Build the Helper Project"	
	dotnet build .\Helper --configuration Release
	dotnet build .\Helper --configuration Debug
	dotnet publish .\Helper --configuration Release
	dotnet publish .\Helper --configuration Debug
echo "	3. Copy Helper to WebApi and WebApp Lib"
	copy "%HELPPER_PUBLISH_DEBUG%\*.*" "%WEB_API_LIB%"
	copy "%HELPPER_PUBLISH_DEBUG%\*.*" "%WEB_APP_LIB%"
echo "	4. Build the WebApi Project"	
	dotnet build .\WebApi --configuration Release
	dotnet build .\WebApi --configuration Debug
	dotnet publish .\WebApi --configuration Release
	dotnet publish .\WebApi --configuration Debug
echo "	5. Build the WebApp Project"	
	dotnet build .\WebApp --configuration Release
	dotnet build .\WebApp --configuration Debug
	dotnet publish .\WebApp --configuration Release
	dotnet publish .\WebApp --configuration Debug
	cd "/d %WEB_APP%"
	echo %WEB_APP%
	dotnet run
echo "**********************************************************************************************************************************************************************"
echo "Finish Build DotNet Core App"
pause