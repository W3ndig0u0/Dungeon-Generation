using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
  public static bool gameIsPaused = false;
  public GameObject pauseMenuUI;
  public GameObject miniMap;
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (gameIsPaused)
      {
        Resume();
      }
      else
      {
        Pause();
      }
    }
  }
  public void Pause()
  {
    pauseMenuUI.SetActive(true);
    miniMap.SetActive(false);
    Time.timeScale = 0f;
    gameIsPaused = true;
    Cursor.visible = true;
    FindObjectOfType<AudioManager>().Stop("PauseLoop");
  }
  public void Resume()
  {
    pauseMenuUI.SetActive(false);
    miniMap.SetActive(true);
    Time.timeScale = 1f;
    gameIsPaused = false;
    // Cursor.visible = false;
    FindObjectOfType<AudioManager>().Stop("PauseLoop");
  }

  public void Menu()
  {
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
  }
  public void QuitGame()
  {
    print("Quit");
    Application.Quit();
  }
}
