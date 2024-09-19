using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFollower : MonoBehaviour
{
    [SerializeField] private GameObject worldObjectToFollow;

    void Update()
    {
        Vector3 worldObjectWorldPosition = worldObjectToFollow.transform.position;
        Vector3 worldObjectScreenPosition = Camera.main.WorldToScreenPoint(worldObjectWorldPosition);

        transform.position = worldObjectScreenPosition;
    }
}