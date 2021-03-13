using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        gameHasEnded = true;

        animator.SetTrigger("EndGame");
        
    }


    public void RestartLevel()
    {
        SceneManager.LoadScene("MainLevel");
        Score.lives -= 1;
    }

    private void Update()
    {
        if(TimerCountdown.sendcondLeft == 0)
        {
            rotator.enabled = false;
            spawner.enabled = false;
            Debug.Log("Time is stoped");
        }

        if(Score.lives == 0)
        {
            SceneManager.LoadScene("Exit");
        }
    }


}
