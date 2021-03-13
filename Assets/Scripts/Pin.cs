using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public static float speed = 100f;


    public Rigidbody2D rb;


    private void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);   //parenting the pin to rotator
            isPinned = true;
            Score.PinCount++;
        }

        else if  (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();    // call endgame function in game manager
        }
    }


}
