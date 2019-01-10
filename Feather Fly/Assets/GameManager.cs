using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject startMenu;
    public GameObject pauseMenu;
    public GameObject game;
    public GameObject deathScreen;

    //public bool gameRun = true;
    


	// Initialize S
	void Start() {
        startMenu.SetActive(true);

        pauseMenu.SetActive(false);
        game.SetActive(false);
        deathScreen.SetActive(false);

	}
	
	// Update is called once per frame
	
    public void StartGame()
    {
        Debug.Log("Game Started?");
        startMenu.SetActive(false);
        game.SetActive(true);
    }

    public void PauseMenu()
    {
        // "Pause" the game.
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        // "Resume" the game.
        Time.timeScale = 1;
    }

    public void DeathScreen()
    {
        game.SetActive(false);
        deathScreen.SetActive(true);

    }

}
