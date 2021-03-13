using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;

    public Spawner spawner;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        spawner.enabled = true;
    }

    void Pause() 
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        spawner.enabled = false;
    }

    public void menuLoad()
    {
        SceneManager.LoadScene("Menu");
        Resume();
    }

    public void exitLoad()
    {
        SceneManager.LoadScene("Exit");
        Resume();
    }

    public void saveGame()
    {
        PlayerPrefs.SetInt("score", Score.PinCount);
        PlayerPrefs.SetInt("live", Score.lives);
        PlayerPrefs.SetString("name",SaveData.nameText);
        PlayerPrefs.SetInt("timeleft", TimerCountdown.sendcondLeft);

        Debug.Log("Game is saved, Score: " + Score.PinCount + ", Live: " + Score.lives + ", Time left: "+ TimerCountdown.sendcondLeft+ "s, Name: " + SaveData.nameText);
    }

    public void loadGame()
    {
        Score.PinCount = PlayerPrefs.GetInt("score");
        Score.lives = PlayerPrefs.GetInt("live");
        SaveData.nameText = PlayerPrefs.GetString("name");
        TimerCountdown.sendcondLeft = PlayerPrefs.GetInt("timeleft");

        Resume();
        SceneManager.LoadScene("MainLevel");

        Debug.Log("Load Saved Game!" + "Score: " + Score.PinCount);
    }

    public void MusicToggle()
    {
        if (MusicScript.BgInstance.Audio.isPlaying)
        {
            MusicScript.BgInstance.Audio.Pause();
        }
        else
        {
            MusicScript.BgInstance.Audio.Play();
        }
    }

}
