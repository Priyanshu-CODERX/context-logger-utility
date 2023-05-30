using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
public class Testers : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LoggerUtility.Instance.Log(LOGS.MESSAGE, "LOGGING MESSAGE");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            LoggerUtility.Instance.Log(LOGS.ERROR, "LOGGING ERROR");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            LoggerUtility.Instance.Log(LOGS.WARNING, "LOGGING WARNING");
        }
    }
}
