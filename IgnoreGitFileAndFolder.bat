@echo off
set ROOT_PROJECT_FOLDER=%cd%
set GIT_IGNORE_FILE=.gitignore
echo "Begin  Run Ignore Git File And Folder"
echo "**********************************************************************************************************************************************************************"
echo "	1. Go to the root project folder : %ROOT_PROJECT_FOLDER%"
	cd "/d %ROOT_PROJECT_FOLDER%"
echo "	2. Ignore the file based on content of .gitignore"	
	for /f "delims=" %%a in (%GIT_IGNORE_FILE%) do ( 
echo "		Line content : %%a" 
	  git update-index --assume-unchanged .%%a 2>nul
	)
echo "	3. Ignore the folder based on content of .gitignore"	
	git config --global core.excludesFile ~/.gitignore
echo "**********************************************************************************************************************************************************************"
echo "Finish Run Ignore Git File And Folder"