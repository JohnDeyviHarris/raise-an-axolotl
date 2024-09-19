using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Happy : MonoBehaviour
{
    public int happy = 100;
    public int maxhappy = 100;
    public int minhappy = 0;
    public int sadcooldown = 2;
    public int happydamage = 1;
    public float happypluscooldown = 0.1f;
    private bool happypluscooldownbool = false;
    private AxolotlSounds AxolotlSounds;
    public event Action<bool> HappyZero;
    private void Start()
    {
        StartCoroutine(Happyminus());
        AxolotlSounds = gameObject.GetComponent<AxolotlSounds>();
    }
    private void FixedUpdate()
    {
        UIManager.UpdateHappy(happy);
    }
    private IEnumerator Happyminus()
    {
        yield return new WaitForSeconds(sadcooldown);
        happy -= happydamage;
        happy = Mathf.Clamp(happy, 0, maxhappy);
        if (happy < minhappy)
        {
            HappyZero.Invoke(true);
        }
        //StartCoroutine(Happyminus());
    }
    public void OnClick()
    {
        if (!happypluscooldownbool && happy != maxhappy)
        {
            StartCoroutine(HappyPlus());
        }
    }
    private IEnumerator HappyPlus()
    {
        happypluscooldownbool = true;
        happy += 1;
        if (happy > minhappy)
        {
            HappyZero.Invoke(false);
        }
        happy = Mathf.Clamp(happy, 0, maxhappy);
        AxolotlSounds.PlayIdleSound();
        yield return new WaitForSeconds(happypluscooldown);
        happypluscooldownbool = false;
    }
}
