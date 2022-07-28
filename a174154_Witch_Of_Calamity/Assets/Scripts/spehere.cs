using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spehere : MonoBehaviour
{
    public Transform player;
    public float cameraDistance = 5;
    public float cameraHeight = 3;
    public float smoothTime = 0.5f;
    public float speed = 10;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
        transform.LookAt(player.transform);
        Vector3 offset = (Camera.main.transform.position - player.position).normalized * cameraDistance;
        Vector3 targetPosition = player.position + offset;
        targetPosition.y = cameraHeight;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, speed);
    }
}
