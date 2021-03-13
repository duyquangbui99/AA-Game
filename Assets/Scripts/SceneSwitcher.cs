using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public void loadPlay()
    {
        SceneManager.LoadScene("MainLevel");
        
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void loadExit()
    {
        SceneManager.LoadScene("Exit");
    }

    public void quitApp()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void playAgain()
    {
        SceneManager.LoadScene("MainLevel");
        Score.PinCount = 0;
        Score.lives = 1;
        TimerCountdown.sendcondLeft = 20;

    }
}


