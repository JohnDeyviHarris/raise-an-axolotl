using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxolotlSounds : MonoBehaviour
{
    [SerializeField] private List<AudioSource> AxolotlIdle;
    
    public void PlayIdleSound()
    {
        int random = Random.Range(0,AxolotlIdle.Count);
        AxolotlIdle[random].Play();
    }
}
