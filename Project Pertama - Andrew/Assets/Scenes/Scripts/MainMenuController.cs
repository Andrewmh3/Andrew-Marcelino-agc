using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
