using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public Transform player;
    public GameObject initialBullet;
    public GameObject bullets;
    public float bulletForce;

    private float countDownbetweenFire = 0f;
    [SerializeField] private float FireRate = 2f;

    int MoveSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Vector3.Distance(transform.position, player.position) <= 3f)
        {
            transform.LookAt(player);
            GameObject temporaryBullet;
            temporaryBullet = Instantiate(bullets, initialBullet.transform.position, initialBullet.transform.rotation) as GameObject;

            temporaryBullet.transform.Rotate(Vector3.forward * 90);

            Rigidbody temporaryRigidbody;
            temporaryRigidbody = temporaryBullet.GetComponent<Rigidbody>();

            temporaryRigidbody.AddForce(transform.forward * bulletForce);

            if (Vector3.Distance(transform.position, player.position) <= 4f)
            {
                if (countDownbetweenFire <= 0f)
                {
                    transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                    countDownbetweenFire = 2f / FireRate;
                }              

            }

            Destroy(temporaryBullet, 10.0f);
        }
    }

    
}
