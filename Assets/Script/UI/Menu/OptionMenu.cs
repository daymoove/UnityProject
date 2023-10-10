using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public void BackToMenu()
    {
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }
}
