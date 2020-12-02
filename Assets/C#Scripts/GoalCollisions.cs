using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoalCollisions : MonoBehaviour
{
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
            RegisterCollision(collision);
        }
        else
        {
            SceneManager.LoadScene(0);
        }    
    }

    private void RegisterCollision(Collision collision)
    {
        if (collision.transform.name == "Ball")
        {
            scoreBoard.ScoreHit();
            Debug.Log("Point Scored!");
        }
    }
}
