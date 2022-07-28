using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public GameObject exitDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //GetComponent<starCollect>();
        if (other.CompareTag("Player") )
        {
           
            
            exitDoor.SetActive(true);
        }
       
    }

}
