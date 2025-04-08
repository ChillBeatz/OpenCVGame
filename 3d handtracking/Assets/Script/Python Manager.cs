using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PythonManager : MonoBehaviour
{
    private const string PythonAppName = "/Python/dist/Aimouse/Aimouse.exe";

    private static Process PythonProcess;

    [RuntimeInitializeOnLoadMethod]
    private static void RunOnStart()
    {
        UnityEngine.Debug.Log(Application.dataPath + PythonAppName);

        ProcessStartInfo PythonInfo = new ProcessStartInfo();
        PythonInfo.FileName = Application.dataPath + PythonAppName;
        PythonInfo.WindowStyle = ProcessWindowStyle.Hidden;
        PythonInfo.CreateNoWindow = true;

        PythonProcess = Process.Start(PythonInfo);
        UnityEngine.Debug.Log("True");

        Application.quitting += () =>
            { if (!PythonProcess.HasExited) PythonProcess.Kill(); };
    }
}
