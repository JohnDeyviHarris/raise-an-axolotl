using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float RotateX = 0;
    [SerializeField] private float RotateY = 0;
    [SerializeField] private float RotateZ = 0;
    private void FixedUpdate()
    {
        gameObject.transform.Rotate(RotateX * Time.fixedDeltaTime, RotateY * Time.fixedDeltaTime, RotateZ * Time.fixedDeltaTime);
    }
}
