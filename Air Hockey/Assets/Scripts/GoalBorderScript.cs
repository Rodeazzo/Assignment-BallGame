﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalBorderScript : MonoBehaviour {

    public int playerScore, scoreMultiplier;
    public Text scoreDisplay;

    int p1Score, p2Score;
    public static int p1FinalScore, p2FinalScore, p1Total, p2Total;
    int currentScene;

    // Use this for initialization
    void Start () {
        p1Score = 0;
        p2Score = 0;
        scoreDisplay.text = "0";

        // Get current scene index
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "P1Goal")
        {
            //print("Player 2 Scored!");
            p2Score+=scoreMultiplier;
            p2Total+=scoreMultiplier;
            scoreDisplay.text = p2Score.ToString ();
            RestartPuck();
        }
        else if (this.tag == "P2Goal")
        {
            //print("Player 1 Scored!");
            p1Score+=scoreMultiplier;
            p1Total+=scoreMultiplier;
            scoreDisplay.text = p1Score.ToString ();
            RestartPuck();
        }
    }

    void RestartPuck()
    {
        PuckScript puck;
        puck = GameObject.FindObjectOfType<PuckScript>();

        puck.gameStart = false;
    }

    // Update is called once per frame
    void Update () {

        if(p1Score == playerScore || p2Score == playerScore)
        {
            if (p1Score > p2Score)
                p1FinalScore += 1;
            else
                p2FinalScore += 1;

            LevelManager.LoadNextLevel(currentScene);
        }
    }
}
