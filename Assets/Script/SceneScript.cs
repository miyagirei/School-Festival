using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneScript : MonoBehaviour
{
    public void TutorialScene()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    public void Continue()
    {
        SceneManager.LoadScene("ContinueScene");
    }
    public void Stage2()
    {
        SceneManager.LoadScene("Stage2Scene");
    }
    public void Stage3()
    {
        SceneManager.LoadScene("Stage3Scene");
    }
    public void Stage4()
    {
        SceneManager.LoadScene("Stage4Scene");
    }
    public void Opening()
    {
        SceneManager.LoadScene("OpeningScene");
        Time.timeScale = 1f;
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
