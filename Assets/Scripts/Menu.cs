using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
  public static bool GameIsPaused = false;

  public GameObject SettingMenuUI, ScoreMenuUI, StartMenuUI, MultiMenuUI, NameMenuUI, MenuUI, QuitUI;

  public void StartSinglePlayer()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void Score()
  {
    ScoreMenuUI.SetActive(true);
    MenuUI.SetActive(false);
  }
  public void Play()
  {
    StartMenuUI.SetActive(true);
    MenuUI.SetActive(false);
  }
  public void PlayMulti()
  {
    MultiMenuUI.SetActive(true);
    NameMenuUI.SetActive(false);
  }
  public void Name()
  {
    NameMenuUI.SetActive(true);
    MenuUI.SetActive(false);
  }
  public void Setting()
  {
    SettingMenuUI.SetActive(true);
    MenuUI.SetActive(false);
  }
  public void Quit()
  {
    QuitUI.SetActive(true);
    MenuUI.SetActive(false);
  }

  public void BackPlay()
  {
    StartMenuUI.SetActive(false);
    MenuUI.SetActive(true);
  }

  public void BackMulti()
  {
    MultiMenuUI.SetActive(false);
    NameMenuUI.SetActive(true);
  }
  public void BackName()
  {
    NameMenuUI.SetActive(false);
    MenuUI.SetActive(true);
  }
  public void BackSetting()
  {
    SettingMenuUI.SetActive(false);
    MenuUI.SetActive(true);
  }
  public void BackScore()
  {
    ScoreMenuUI.SetActive(false);
    MenuUI.SetActive(true);
  }
  public void BackQuit()
  {
    QuitUI.SetActive(false);
    MenuUI.SetActive(true);
  }
  public void QuitGame()
  {
    print("Quit");
    Application.Quit();
  }
}
