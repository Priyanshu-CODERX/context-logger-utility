# Context Logger Utility
Logger Utility for Unity Engine is a powerful and essential tool designed to streamline the process of error logging, message tracking, and warning management within the user interface (UI) of your Unity projects. With its intuitive interface and robust functionality, Logger Utility provides developers with a comprehensive solution for efficiently tracking and managing logs during the development and debugging stages.

One of the key features of Logger Utility is its flexible configuration options. Developers have the freedom to specify the level of severity for each type of log entry, enabling them to prioritize and categorize logs based on their importance. Whether it's critical errors, warnings, or informational messages, Logger Utility ensures that you have complete control over the logging process.

With Logger Utility, debugging and monitoring your Unity projects becomes a streamlined and efficient process. By leveraging this tool's comprehensive logging capabilities, you can easily identify and resolve project related errors, warnings, and messages, ensuring a smooth and error-free user experience.

**NOTE:** The Logger Utility is currently in the process of being developed and is undergoing continuous improvements to ensure a seamless user experience. While it may have a few existing bugs, the developer is diligently working to address them and enhance the functionality of the utility.

## ⚒️ Development Environment
- Visual Studio Code
- Unity Engine 2021.3.15f1

# Getting Started
To start using Logger Utility in your Unity project, follow these steps:

## Step 1: Importing Logger Utility
- Import LoggerUtility Unity Package from Github
- Make sure you have TextMeshPro installed in your project, as the LoggerUtility uses TMP_Text for logging.

## Step 2: Setting Up Logger Utility Instance
- Create an empty GameObject in your scene and rename it to "LoggerUtility".
- Attach the LoggerUtility script to the "LoggerUtility" GameObject.
- Ensure that the TMP_Text component is assigned to the LOGGER field in the Inspector.
- Set the appropriate font, size, and other text properties for the TMP_Text component to suit your needs.
- You can also make use of LoggerUtility Prefab which already contains all the configured assets

## Step 3: Accessing the LoggerUtility Instance
In any script where you want to use the LoggerUtility, add the following using statement at the top:
```csharp
using Utils;
```
To access the LoggerUtility instance, use the following code:
```csharp
LoggerUtility logger = LoggerUtility.Instance;
```

## Step 4: Logging Messages, Errors and Warnings
Logger Utility provides three log levels: MESSAGE, ERROR, and WARNING. Use the Log method to log messages with the desired log level.

```csharp
// Log a message
logger.Log(LOGS.MESSAGE, "This is a message.");

// Log a warning
logger.Log(LOGS.WARNING, "This is a warning.");

// Log an error
logger.Log(LOGS.ERROR, "This is an error.");
```

## Customization and Configuration
Logger Utility offers flexible configuration options to customize the logging behavior. You can modify the severity level and appearance of each log type by editing the Log method in the LoggerUtility script.

- To modify the severity levels or add new log types, modify the LOGS enum in the LoggerUtility script.
- To change the appearance or color of the log messages, modify the LOGGER concatenation code within the Log method. You can use rich text tags for formatting and color customization.

Logger Utility is a powerful tool for efficient error logging, message tracking, and warning management in Unity projects. By using the provided LoggerUtility script and following the instructions outlined in this documentation, you can streamline your debugging process and ensure a smooth user experience.