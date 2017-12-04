using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;
    }

    public void LoadGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
