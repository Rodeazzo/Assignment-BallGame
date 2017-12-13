using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Cursor.visible = true;
    }

    public void LoadGame(string sceneName)
    {
        // Initialize global static variables to 0 on replay/start game
        GoalBorderScript.p1FinalScore = 0;
        GoalBorderScript.p2FinalScore = 0;
        GoalBorderScript.p1Total = 0;
        GoalBorderScript.p2Total = 0;

        SceneManager.LoadScene(sceneName);
        Cursor.visible = false;
    }

    public static void LoadNextLevel(int currentScene)
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    // Update is called once per frame
    void Update () {

    }
}
