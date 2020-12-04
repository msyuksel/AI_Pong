using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    //Attatched to the Text of the UI. Child of Canvas
    //Need to save scores made through scene reloads, if the scene reload happens because of enemy base collision
    public int scorePerHit = 10;

    public int score;
    int scoreAI;

    public Text scoreText;
    public Text highScore;
    public Text aIScore;

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        scoreText.text = score.ToString();
        aIScore.text = scoreAI.ToString();
    }

    public void ScoreHit(bool trueFalse)
    {
        
        if (trueFalse == true)
        {
            score = score + scorePerHit;
            CountHighScore();
            scoreText.text = score.ToString();
        }
        else if (trueFalse == false)
        {
            CountAIScore();
            score = 0;
            scoreText.text = "0";
        }

        Debug.Log("scored " + score + " points");
    }

    public void CountHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }
    }

    public void CountAIScore()
    {
        scoreAI++;
        aIScore.text = scoreAI.ToString();
    }
}
