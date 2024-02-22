using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;

    private AudioSource SourceMainBGM;
    private AudioSource SourceWalking;
    private AudioSource SourceAttack;
    private AudioSource SourceSkill;
    private AudioSource SourcePlayerHit;
    private AudioSource SourceMonsterHit;

    public AudioClip[] AudioClipMainBGM;

    public AudioClip[] AudioClipSkill;

    public AudioClip[] AudioClipHit;

    public AudioClip[] AudioClipACT;

    private void Awake()
    {
        if(soundManager == null)
        {
            soundManager = this;
        }
        else
        {
            Destroy(gameObject);
        }

        SourceMainBGM = transform.Find("BGM/SourceMainBGM").GetComponent<AudioSource>();

        SourceWalking = transform.Find("Action/SourceWalking").GetComponent<AudioSource>();

        SourceAttack = transform.Find("Battle/SourceAttack").GetComponent<AudioSource>();
        SourceSkill = transform.Find("Battle/SourceSkill").GetComponent<AudioSource>();

        SourcePlayerHit = transform.Find("Damage/SourcePlayerHit").GetComponent<AudioSource>();
        SourceMonsterHit = transform.Find("Damage/SourceMonsterHit").GetComponent<AudioSource>();
    }
    public void Play(AudioSource _audio, AudioClip _clip)
    {
        if (_clip != null)
        {
            _audio.clip = _clip;
        }
        if (_audio != null)
        {
            _audio.Stop();
            _audio.PlayOneShot(_clip);
        }
    }
    public void Stop(AudioSource _audio)
    {
        _audio.Stop();
    }
}
