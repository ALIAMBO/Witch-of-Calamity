using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseComponent : MonoBehaviour
{
    public Transform player;
    //public Transform chase;
    int MoveSpeed = 3;
     Renderer mat;

    public Animator spider;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>();

        spider = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) <= 5f)
        {
            spider.SetBool("Run", true);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
        else
        {
            spider.SetBool("Run", false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        mat.material.color = Color.blue;
    }
}
