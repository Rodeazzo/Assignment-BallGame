using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinnerScript : MonoBehaviour {

    public Text winnerDisplay;
    static int currentScene, p1Wins, p2Wins, p1Total, p2Total;

    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene().buildIndex;

        p1Wins = GoalBorderScript.p1FinalScore;
        p2Wins = GoalBorderScript.p2FinalScore;
        p1Total = GoalBorderScript.p1Total;
        p2Total = GoalBorderScript.p2Total;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (currentScene == 4)
        {
            if (p1Wins > p2Wins)
            {
                winnerDisplay.text = "<color=#0000ffff>Player 1</color> Total Goals - " + p1Total + "\t Games Won - " + p1Wins + "\n" +
                                     "<color=#ff0000ff>Player 2</color> Total Goals - " + p2Total + "\t Games Won - " + p2Wins +
                                     "\n\n<color=#0000ffff>Player 1</color> Wins! \n \n Thank you for playing!";

            }
            else if (p1Wins > p2Wins)
            {
                winnerDisplay.text = "<color=#0000ffff>Player 1</color> Total Goals - " + p1Total + "\t Games Won - " + p1Wins + "\n" +
                                     "<color=#ff0000ff>Player 2</color> Total Goals - " + p2Total + "\t Games Won - " + p2Wins +
                                     "\n\n<color=#ff0000ff>Player 2</color> Wins! \n \n Thank you for playing!";
            }
            else
            {
                winnerDisplay.text = "Play the game first!";
            }
               
        }
        
    }
}
