using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField]
    private GameObject privateGround;

    public GameObject publicGround;

    private BoxCollider boxCollider;

    void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        Debug.Log("Got the box collider component: " + boxCollider.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Method got executed");

        Debug.Log("Private Ground: " + privateGround.name);
        Debug.Log("Public Ground: " + publicGround.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Method got executed");
    }

    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.name);
    }
}
