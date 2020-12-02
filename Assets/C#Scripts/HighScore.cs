using System;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    ScoreBoard scoreBoard;
    public Text highScoreTxt;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        highScoreTxt = GetComponent<Text>();
        highScoreTxt.text = score.ToString();

    }

    public void HighScoreCounter()
    {
        if (scoreBoard.score > this.score)
        {
            score = scoreBoard.score;
            highScoreTxt.text = scoreBoard.scoreText.text;
        }
        Debug.Log("high score is " + score + " points");
    }
}
