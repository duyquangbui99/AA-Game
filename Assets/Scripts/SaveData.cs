using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public static string nameText;

    public static string lastLiveString;

    public InputField inputField;

    public Dropdown timerDropdown;

    public Dropdown liveDropdown;

    public Slider candySpeedSlider;

    public Slider rotatorSpeedSlider;

    public Text WelcomeText;

    public Text candySpeedtxt;

    public Text rotatorSpeedtxt;

    public void nameUpdate()
    {
        nameText = inputField.text;


        WelcomeText.text = "Welcome " + nameText + " to AA game!";
    }


    public void timerUpdate()
    {
        switch(timerDropdown.value)
        {
            default:
                TimerCountdown.sendcondLeft = 20;
                break;
            case 0:
                TimerCountdown.sendcondLeft = 20;
                break;
            case 1:
                TimerCountdown.sendcondLeft = 40;
                break;
            case 2:
                TimerCountdown.sendcondLeft = 60;
                break;
        }
    }

    public void liveUpdate()
    {
        switch (liveDropdown.value)
        {
            default:
                Score.lives = 1;
                lastLiveString = "Live: 1";
                break;
            case 0:
                Score.lives = 1;
                lastLiveString = "Live: 1";
                break;
            case 1:
                Score.lives = 2;
                lastLiveString = "Live: 2";
                break;
            case 2:
                Score.lives = 3;
                lastLiveString = "Live: 3";
                break;
        }
    }


    public void candySpeedUpdate(float value)
    {
        Pin.speed = candySpeedSlider.value;
        candySpeedtxt.text = Pin.speed.ToString("0");
    }


    public void rotatorSpeedUpdate(float value)
    {
        Rotator.speed = rotatorSpeedSlider.value;
        rotatorSpeedtxt.text = Rotator.speed.ToString("0");
    }
}
