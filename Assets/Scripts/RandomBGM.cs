using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomBGM : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgm1;
    public AudioClip bgm2;
    public AudioClip bgm3;
    public float bgmno;
    // Start is called before the first frame update
    void Start()
    {
        RandomPlay();
    }

   
    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            RandomPlay();
        }
    }

    void RandomPlay()
    {
        bgmno = Random.Range(1.0f, 4.0f);
        if (bgmno >= 1.0f && bgmno < 2.0f)
        {
            audioSource.clip = bgm1;
            audioSource.Play();
        }
        else if (bgmno >= 2.0f && bgmno < 3.0f)
        {
            audioSource.clip = bgm2;
            audioSource.Play();
        }
        else if (bgmno >= 3.0f && bgmno <= 4.0f)
        {

            audioSource.clip = bgm3;
            audioSource.Play();
        }
    }

    public void setBack()
    {
        audioSource.clip = null;
    }
}
