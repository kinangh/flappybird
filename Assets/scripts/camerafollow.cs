﻿using UnityEngine;
using System.Collections;

public class camerafollow : MonoBehaviour
{

    public Transform target;

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}