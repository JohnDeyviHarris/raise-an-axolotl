using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Music")]
    [SerializeField] private AudioSource sad;
    [SerializeField] private AudioSource normal;
    [Header("SFX")]
    [SerializeField] private List<AudioSource> AxolotlKryaki;
    private static AudioManager me;
    private void Awake()
    {
        me = this;
    }
    public static void TurnSadMusic(bool sadorno)
    {
        me.sad.enabled = sadorno;
        me.normal.enabled = !sadorno;
    }
}
