using UnityEngine;
using UnityEngine.UI;


public class Lastgamesave : MonoBehaviour
{
    public Text lastScore;

    public Text lastLive;

    void Start()
    {
        lastScore.text = "Score: " + Score.PinCount;

        lastLive.text = SaveData.lastLiveString;
    }


}
