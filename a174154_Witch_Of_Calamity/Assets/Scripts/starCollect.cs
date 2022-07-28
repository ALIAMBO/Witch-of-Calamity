using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class starCollect : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public static int score;
    public AudioClip coinClip;
    AudioSource coinEffect;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        obj = GameObject.Find("AudioStar");
        if (obj != null)
        {
            coinEffect = obj.GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            coinEffect.clip = coinClip;
            coinEffect.Play();
            score++;
            scoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + score;
            Debug.Log("Total coins :" + score);
            Destroy(gameObject);
        }
    }
}
