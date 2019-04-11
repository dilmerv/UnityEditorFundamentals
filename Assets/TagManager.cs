using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        Debug.Log("playerGameObject gameObject: " + playerGameObject.gameObject.name);
        Debug.Log("playerGameObject layer #: " + playerGameObject.layer);
        Debug.Log("playerGameObject layer name: " + LayerMask.LayerToName(playerGameObject.layer));

        GameObject enemyGameObject = GameObject.FindGameObjectWithTag("Enemy");
        Debug.Log("enemyGameObject gameObject: " + enemyGameObject.gameObject.name);   
        Debug.Log("enemyGameObject layer #: " + enemyGameObject.layer);
        Debug.Log("enemyGameObject layer name: " + LayerMask.LayerToName(enemyGameObject.layer));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
