using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

#region Non-Trigger Type Collisions
    private void OnCollisionEnter(Collision other) {
        Debug.Log("OnCollisionEnter");
        Debug.Log(other.gameObject.name);
    }

    private void OnCollisionStay(Collision other) {
        Debug.Log("OnCollisionStay");
        Debug.Log(other.gameObject.name);
    }

    private void OnCollisionExit(Collision other) {
        Debug.Log("OnCollisionExit");
        Debug.Log(other.gameObject.name);
    }

#endregion

#region Trigger Type Collisions

    private void OnTriggerEnter(Collider other) {
        Debug.Log("OnTriggerEnter");
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log("OnTriggerStay");
        Debug.Log(other.gameObject.name);
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("OnTriggerExit");
        Debug.Log(other.gameObject.name);
    }

#endregion
}
