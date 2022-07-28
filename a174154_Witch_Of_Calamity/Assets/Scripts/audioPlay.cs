using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
    public AudioSource buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playButton()
    {
        buttonSound.Play();
        Debug.Log("Play");
    }
}
