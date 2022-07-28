using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Renderer mat;

   
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>();

        //spider = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        mat.material.color = Color.red;
    }

    void OnTriggerExit(Collider other)
    {
        mat.material.color = Color.white;
    }
}
