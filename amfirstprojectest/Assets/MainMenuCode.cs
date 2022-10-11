using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MainPlaayMenu()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
