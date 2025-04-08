using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PythonManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("Launch Python Script",GUILayout.Height(35)))
        {
            Debug.Log("Yes");
        }
    }
}
