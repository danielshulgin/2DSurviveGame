using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    [SerializeField]
    float startForce = 20f;
    [SerializeField]
    float lifeTime = 2f; 

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.up.x, transform.up.y) * startForce);
        StartCoroutine(LifeCycle());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    IEnumerator LifeCycle()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
