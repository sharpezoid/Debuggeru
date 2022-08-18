using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class Debugger : MonoSingleton<Debugger>
{
    public Text debugText;

    public void AddLog(string _message)
    {
        string oldMessage = debugText.text;
        oldMessage += "\n";
        oldMessage += _message;
        debugText.text = "<color=blue> blue text </color>";
    }
}
