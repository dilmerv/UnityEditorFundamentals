using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource firstTrack;


    [SerializeField]
    private AudioSource secondTrack;


    // Start is called before the first frame update
    void Start()
    {
        if(firstTrack == null){
            Debug.Log("First Track has not been set...");
            enabled = false;
        }

        if(secondTrack == null){
            Debug.Log("Second Track has not been set...");
            enabled = false;
        }

        firstTrack.Play();
        secondTrack.Play();

        firstTrack.volume = 0.1f;
        secondTrack.volume = 0.8f;

        firstTrack.loop = true;
        secondTrack.pitch = 0.4f;
    }
}
