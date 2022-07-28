using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerProximity : MonoBehaviour
{
    public GameObject target;
    Rigidbody parentrb;

    public float speed = 1f;
    //int MoveSpeed = 3;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Cube");
        parentrb = GetComponentInParent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 90 * Time.deltaTime);
    }

    public  void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
        {
            parentrb.useGravity = false;
            direction = target.transform.position - transform.position;
        }
    }

    private void FixedUpdate()
    {
        //parentrb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
    }
}
