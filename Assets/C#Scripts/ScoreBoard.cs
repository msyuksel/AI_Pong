using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    //Attatched to the Text of the UI. Child of Canvas
    //Need to save scores made through scene reloads, if the scene reload happens because of enemy base collision
    public int scorePerHit = 10;

    public int score;
    public Text scoreText;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    public void ScoreHit()
    {
        score = score + scorePerHit;
        scoreText.text = score.ToString();
        Debug.Log("scored " + score + " points");
    }

}
