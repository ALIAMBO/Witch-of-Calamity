using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialgoueTrigger : MonoBehaviour
{
    public GameObject dialgoue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialgoue.SetActive(true);
        }
    }

    public void onclick()
    {
        dialgoue.SetActive(false);
    }
}
