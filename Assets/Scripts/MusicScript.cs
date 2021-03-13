using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static MusicScript BgInstance;

    public AudioSource Audio;

    private void Awake()
    {
        if(BgInstance != null & BgInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        BgInstance = this;
        DontDestroyOnLoad(this);
    }

    public void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

}
