using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderManagement : MonoBehaviour
{
    public Transform player;
    public Animation anim;

    public int MoveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        //anim.Play("Walk");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        if (Vector3.Distance(transform.position, player.position) <= 5f)
        {
             //anim.Play("Walk");
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
       
    }

}
