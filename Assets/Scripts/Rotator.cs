using UnityEngine;

public class Rotator : MonoBehaviour
{
    public static float speed = 100f;

    private void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

}
