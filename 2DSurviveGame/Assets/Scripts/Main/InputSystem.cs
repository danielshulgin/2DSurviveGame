using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystem : MonoBehaviour
{
    public event Action<Vector2> Move;
    public event Action<Vector2> LookDirection;
    public event Action LeftButtonClick;

    [SerializeField]
    Transform playerTransform;

    void Update()
    {
        Move?.Invoke(Time.deltaTime * new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (LookDirection != null)
        {
            Vector3 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - playerTransform.position;
            LookDirection(new Vector2(direction.x, direction.y));
        }
        if (Input.GetButtonDown("Fire1"))
        {
            LeftButtonClick();
        }
    }
}
