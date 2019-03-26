using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifecycleEvents : MonoBehaviour
{

    // First method executed
    void Awake()
    {
        Debug.Log("Awake is executed");
    }

    // Second method executed
    void Start()
    {
        Debug.Log("Start is executed");
    }

    // Third method executed
    // executed on every frame at least once
    void Update()
    {
        Debug.Log("Update is executed");
    }

    // Fourth method executed
    // executed on every frame at least once and after the update
    void LateUpdate()
    {
        Debug.Log("LateUpdate is executed");
    }

    // Fifth method executed
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate is executed");
    }

    // Whenever we enable a game object
    void OnEnable()
    {
        Debug.Log("OnEnable is executed");
    }

    // Whenever we disable a game object
    void OnDisable()
    {
        Debug.Log("OnDisable is executed");
    }

    // Whenever we destroy a game object
    void OnDestroy()
    {
        Debug.Log("OnDestroy is executed");
    }
}
