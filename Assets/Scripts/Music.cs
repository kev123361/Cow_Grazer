using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

    private AudioSource _audioSource;
    public AudioClip[] bgm;
    public GameController gc;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        ChooseClip();
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }

    private void ChooseClip()
    {
        _audioSource.clip = bgm[gc.spots];
    }
}
