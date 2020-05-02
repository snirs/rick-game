using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // True is the game is paused, false if the game is not paused
    public static bool GameIsPaused = false;
    
    //The pause menu game object
    public GameObject pauseMenuUI;
    public GameObject gameOverMenuUI;
    public PlayerBars playerBars;

    // Update is called once per frame
    void Update(){
    if (Input.GetKeyDown(KeyCode.Escape)){
        if (GameIsPaused){
            Resume();
        }else{
            Pause();
        }
    }
        
    }
    
    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    
    }
    public void GameOver(){
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = true;

    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void RestartGame(){
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void LoadMenu(){
        Application.Quit();
    }

}
