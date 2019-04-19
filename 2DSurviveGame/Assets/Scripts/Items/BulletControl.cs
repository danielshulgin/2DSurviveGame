using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public float speed = 20f;
    public Vector3 shotStartDirection = Vector3.zero;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SimplePool.Despawn(gameObject);
    }
}
