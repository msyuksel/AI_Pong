using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalCollisions : MonoBehaviour
{
    //This is the Ball script
    //Need to give ScoreBoard the power to control scene reloads on collision
    public bool isPlayerGoal;

    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (!isPlayerGoal)
        {
            //RegisterCollision(collision);
            scoreBoard.ScoreHit(false);
            SceneManager.LoadScene(1);
        }
        else
        {
            scoreBoard.ScoreHit(true);
            SceneManager.LoadScene(1);
        }

    }

    /*
    private void RegisterCollision(Collision collision)
    {
        if (collision.transform.name == "Ball")
        {
            scoreBoard.ScoreHit(trueFalse);
            Debug.Log("Point Scored!");
        }
    }
    */
    
}
