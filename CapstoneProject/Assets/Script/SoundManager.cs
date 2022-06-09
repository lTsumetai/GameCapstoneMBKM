using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip btn_Click;
    public AudioClip victory;
    public AudioClip clawMove;

    private AudioSource audio;

    private void Awake()
    {
   /*     if (instance != null)
            Destroy(gameOver);
        else*/
            instance = this;
        audio = GetComponent<AudioSource>();
    }

    public void ButtonClickSfx()
    {
        audio.PlayOneShot(btn_Click);
    }

    public void ClawMoveSfx()
    {
        audio.PlayOneShot(clawMove);
    }

}
