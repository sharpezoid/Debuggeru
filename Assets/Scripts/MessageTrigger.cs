using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debugger.Instance.AddLog("This is a message!");
    }
}
