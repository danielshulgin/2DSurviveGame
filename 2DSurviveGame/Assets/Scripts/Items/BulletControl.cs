using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    [SerializeField]
    float speed = 20f;
    public Vector3 shotStartDirection = Vector3.zero;
    public bool on;

    private void Update()
    {
        if(on)
            Move();
    }

    private void Move()
    {
        this.transform.position += new Vector3( shotStartDirection.x, shotStartDirection.y, 0f) * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        on = false;
        SimplePool.Despawn(gameObject);
    }
}
