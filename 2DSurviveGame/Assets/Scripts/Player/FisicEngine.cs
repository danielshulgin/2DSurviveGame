﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicEngine : MonoBehaviour
{
    [SerializeField]
    InputSystem inputSystem;
    [SerializeField]
    Transform playerHeadTransform;
    [SerializeField]
    float speed = 10f;

    void Start()
    {
        inputSystem.LookDirection += Rotate;
        inputSystem.Move += Move;
    }

    public void Move(Vector2 direction)
    {
        this.transform.position = this.transform.position + new Vector3(direction.x, direction.y, 0f) * speed;
    }

    public void Rotate(Vector2 direction)
    { 
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        playerHeadTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}