using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeApplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnExit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}