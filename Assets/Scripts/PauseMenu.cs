using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenuScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauseMenuScreen.activeSelf){
                pauseMenuScreen.SetActive(false);
            }
            else{
                pauseMenuScreen.SetActive(true);
            }
        }
    }
    public void PauseGame()
    {
        pauseMenuScreen.SetActive(true);
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Resume()
    {
        pauseMenuScreen.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
