# Windows_Console_Application_As_A_Service
## Windows Console Application As A Service

#### 1. How to install:

##### a. First Navigate to the solution bin and select from debug or release solution builded project, then copy and paste somewhere else you want to store the project main files.

##### b. Now you have to prompt command as admin user and navigate to the folder where you stored your project files.

##### c. Now you have to simply execute command:
```YourProjectName.exe install start```

##### d. And then you can check your service running by pressing ```Windows Key + R```, and then using the following command line:
```services.msc```

##### e.ress Enter and then check your service name in the list.

#### 2. How to Uninstall:

##### a. Same steps as install but instead of at step ```c. ``` you type ```YourProjectName.exe install start```, you are going to type the following:
```YourProjectName.exe uninstall```
