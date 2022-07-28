using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector3 target;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector3(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed*Time.deltaTime);

        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            destroyProjectile();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            destroyProjectile();
        }
    }

    void destroyProjectile()
    {
        Destroy(gameObject);
    }
}
