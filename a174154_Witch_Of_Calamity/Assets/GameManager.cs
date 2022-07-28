using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TMPro.TextMeshProUGUI scoreText;
    public int theScore;
    // Start is called before the first frame update
    void Start()
    {
        theScore = 0;
        scoreText.text = "Score : " + theScore;
    }
   
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            theScore++;
            scoreText.text = "Score : " + theScore;
            Destroy(gameObject);
        }
    }
}
