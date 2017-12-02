using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalBorderScript : MonoBehaviour {

    //ScoreScript getScore;

    int p1Score, p2Score;
    int p1FinalScore, p2FinalScore;
    public Text scoreDisplay;
    int currentScene;

    // Use this for initialization
    void Start () {
        p1Score = 0;
        p2Score = 0;

        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.tag == "P1Goal")
        {
            print("Player 2 Scored!");
            p2Score+=1;
            scoreDisplay.text = p2Score.ToString ();
            RestartPuck();
        }
        else if (this.tag == "P2Goal")
        {
            print("Player 1 Scored!");
            p1Score+=1;
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

        // Level 1
        if (currentScene == 1) {
            if (p1Score == 3)
            {
                p1FinalScore += 1;
                SceneManager.LoadScene(currentScene + 1);
            }
            else if (p2Score == 3)
            {
                p2FinalScore += 1;
                SceneManager.LoadScene(currentScene + 1);
            }
        }
        // Level 2
        else if (currentScene == 2)
        {
            if (p1Score == 5)
            {
                p1FinalScore += 1;
                SceneManager.LoadScene(currentScene + 1);
            }
            else if (p2Score == 5)
            {
                p2FinalScore += 1;
                SceneManager.LoadScene(currentScene + 1);
            }
        }
        // Level 3
        else if (currentScene == 3)
        {
            if (p1Score == 10)
            {
                p1FinalScore += 1;
                SceneManager.LoadScene(currentScene + 1);
            }
            else if (p2Score == 10)
            {
                p2FinalScore += 1;
                SceneManager.LoadScene(currentScene + 1);
            }
        }
    }
}
