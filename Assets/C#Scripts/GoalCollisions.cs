using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollisions : MonoBehaviour
{

    ScoreBoard scoreBoard;

    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Ball")
        {
            scoreBoard.ScoreHit();
            Debug.Log("Point Scored!");
        }
    }
}
