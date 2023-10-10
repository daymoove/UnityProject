using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject optionMenu;
    public void play_game()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Option()
    {
        optionMenu.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
