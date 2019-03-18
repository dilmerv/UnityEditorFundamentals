using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggerExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("(" + gameObject.name + ") The Debugger Example is starting...");

        // Debug.Log("(" + gameObject.name + ") is at position: " + gameObject.transform.position);

        Debug.Log("(" + gameObject.name + ") is at position: " + gameObject.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
