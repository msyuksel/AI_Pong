using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public int scorePerHit = 10;

    public int score;
    public Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    private void Update()
    {
        
    }

    public void ScoreHit()
    {
        score = score + scorePerHit;
        scoreText.text = score.ToString();
        Debug.Log("scored " + score + " points");
    }

}
