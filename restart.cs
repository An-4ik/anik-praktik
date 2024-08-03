using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class restart : MonoBehaviour
{
    public GameObject PausPanel;

  public void resetLelv()
    {
        SceneManager.LoadScene(1);
        //Time.timeScale = 1.0f;
    }

    public void MainManue()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Pause()
    {
        PausPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Rusem()
    {
        PausPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
} 
