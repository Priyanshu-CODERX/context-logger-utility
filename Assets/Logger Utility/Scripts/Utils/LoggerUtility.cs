using UnityEngine;
using TMPro;

namespace Utils
{
    public enum LOGS
    {
        MESSAGE,
        ERROR,
        WARNING
    }

    public class LoggerUtility : MonoBehaviour
    {
        public TMP_Text LOGGER;

        private static LoggerUtility _instance;
        public static LoggerUtility Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<LoggerUtility>();

                    if (_instance == null)
                    {
                        GameObject singleton = new GameObject("LoggerUtility");
                        _instance = singleton.AddComponent<LoggerUtility>();
                        DontDestroyOnLoad(singleton);
                    }
                }
                return _instance;
            }
        }

        // Makes use of Enums to switch between logs
        public void Log(LOGS LogType, string Message)
        {
            // Logs Messages, Erros and Warnings to TextMeshPro
            if (LogType == LOGS.MESSAGE)
            {
                LOGGER.text += $"<color=green>MESSAGE: {Message}</color>\n";
            }

            if (LogType == LOGS.WARNING)
            {
                LOGGER.text += $"<color=yellow>WARNING: {Message}</color>\n";
            }

            if (LogType == LOGS.ERROR)
            {
                LOGGER.text += $"<color=red>ERROR: {Message}</color>\n";
            }
        }
    }
}