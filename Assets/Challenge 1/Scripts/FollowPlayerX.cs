using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    void Awake()
    {
        offset = new Vector3(25f, 0, 5f);
    }

    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
