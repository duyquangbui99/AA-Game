using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;

    public static int lives = 1;

    public Text scoreText;

    public Text NameText;

    public Text liveText;

    public Text highScoreText;
    void Start()
    {
        //PinCount = 0;
        NameText.text = SaveData.nameText;

        liveText.text = "Live: " + lives.ToString();

        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();


    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = PinCount.ToString();

        if (PinCount > PlayerPrefs.GetInt("HighScore", 0))    //set high score
        {
            PlayerPrefs.SetInt("HighScore", PinCount);
            highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }

    }


    public void resetHighScore()
    {
        PlayerPrefs.DeleteAll();
        highScoreText.text = "0";
    }
}
