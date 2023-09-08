using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenuscript : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You Quit the game");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FromAboutToMain()
    {
        SceneManager.LoadScene("Scenes/Main menu");
    }

    public void FromMainToAbout()
    {
        SceneManager.LoadScene("Scenes/About");
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void TryAgain()
    {
        string currentLoadScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Level 1");
    }
    public void TryAgain1()
    {
        string currentLoadScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Level 2");
    }
}
