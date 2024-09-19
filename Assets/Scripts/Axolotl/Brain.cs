using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Brain : MonoBehaviour
{
    [SerializeField] private AIMovement aIMovement;
    [SerializeField] private AudioSource SadMusic;
    [SerializeField] private Volume volume;
    [SerializeField] private ColorCurves colorCurves;
    private Happy happy;
    private AIMovement move;

    private void Start()
    {   
        happy = gameObject.GetComponent<Happy>();
        move = gameObject.GetComponent<AIMovement>();
        happy.HappyZero += SadWorldOhNo;
    }
    private void SadWorldOhNo(bool setorno)
    {
        aIMovement.moveneed = !setorno;
        volume.profile.TryGet<ColorCurves>(out colorCurves);
        colorCurves.active = setorno;
        AudioManager.TurnSadMusic(setorno);
        move.ICanStop(setorno);
    }
}
