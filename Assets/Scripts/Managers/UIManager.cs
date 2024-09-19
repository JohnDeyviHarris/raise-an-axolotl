using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI happyIndicator; 
    private static UIManager instance;
    private void Awake()
    {
        instance = this;
    }
    public static void UpdateHappy(int happy)
    {
        instance.happyIndicator.text = happy.ToString() + "%";
    }
}
