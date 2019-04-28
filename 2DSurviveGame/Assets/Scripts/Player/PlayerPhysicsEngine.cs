using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class PlayerPhysicsEngine : MonoBehaviour
{
    [SerializeField]
    Transform playerHeadTransform = null;
    public InputManager input;

    public float speed = 2f;
    Action<InputAction.CallbackContext> moveHandler;
    Action<InputAction.CallbackContext> directiontHandler;

    void Awake()
    {
        input = FlowController.input;
        moveHandler = context => Move(context.ReadValue<Vector2>());
        directiontHandler = context => Rotate(context.ReadValue<Vector2>());
        input.Player.Move.performed += moveHandler;
        input.Player.Direction.performed += directiontHandler;
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Player.Move.performed -= moveHandler;
        input.Player.Direction.performed -= directiontHandler;
        input.Player.Move.Disable();
        input.Player.Direction.Disable();

    }

    public void Move(Vector2 direction)
    {
        this.GetComponent<Rigidbody2D>().MovePosition(new Vector3(direction.x, direction.y, 0f) * speed * Time.deltaTime + transform.position);
    }

    public void Rotate(Vector2 direction)
    {
        direction = Camera.main.ScreenToWorldPoint(direction) - transform.position;
        direction.Normalize();
        float rot_z = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        playerHeadTransform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
}
