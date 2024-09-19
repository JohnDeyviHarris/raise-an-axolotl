using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMe : MonoBehaviour
{
    [SerializeField] private GameObject LookAt;
    private void FixedUpdate()
    {
        gameObject. transform.LookAt(LookAt.transform);
    }
}
