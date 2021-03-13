using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class TimerCountdown : MonoBehaviour
{
    public Text timeDisplay;
    public static int sendcondLeft = 20;
    private bool takingAway = false;
    void Start()
    {
        timeDisplay.text = "00:" + sendcondLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && sendcondLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }


    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        sendcondLeft -= 1;

        if (sendcondLeft < 10)
        {
            timeDisplay.text = "00:0" + sendcondLeft;
        }
        else
        {
            timeDisplay.text = "00:" + sendcondLeft;
        }
        
        takingAway = false;
    }
}
