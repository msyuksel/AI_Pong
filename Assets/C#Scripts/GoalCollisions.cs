﻿using UnityEngine;
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
            RegisterCollision(collision);
            SceneManager.LoadScene(0);
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

    public void KeepPoints()
    {
        if (!isPlayerGoal)
        {

            SceneManager.LoadScene(0);
        }
    }

    public void ErasePoints()
    {
        if (isPlayerGoal)
        {
            SceneManager.LoadScene(0);
        }
    }
    
}
