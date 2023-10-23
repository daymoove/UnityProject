using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject optionMenu;

    private void Start()
    {
        optionMenu.GetComponent<OptionMenu>().SetVolume(-30);
    }

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
