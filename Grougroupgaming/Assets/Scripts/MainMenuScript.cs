using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
    public void MainPlayMenu()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}