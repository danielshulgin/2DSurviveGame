using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input; 

public class Fire : MonoBehaviour
{
    [SerializeField]
    PlayerManager playerManager = null;
    [SerializeField]
    GameObject bulletPref = null;
    [SerializeField]
    Transform muzzleTransform = null;
    Coroutine shootRoutine;
    //TODO state
    public bool Shooting { get; private set; }
    public InputManager input;

    Action<InputAction.CallbackContext> shootHandler;

    private void Awake()
    {
        input = FlowController.input;
        shootHandler = context =>
        {
            if (context.ReadValue<float>() >= 0.9f)
            {
                StartShooting();
            }
            else
            {
                StopShooting();
            }
        };
        input.Player.Shoot.performed += shootHandler;
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Player.Shoot.performed -= shootHandler;
        input.Player.Shoot.Disable();
    }

    public bool OneShoot()
    {
        Item item = playerManager.inventory.items.Find(_item => _item.itemType == ItemType.Bullet);
        if (item != null && item.Use())
        {
            GameObject bullet = Instantiate(bulletPref, muzzleTransform.position, muzzleTransform.rotation);
            return true;
        }
        return false;
    }

    public void StartShooting()
    {
        Shooting = true;
        if(shootRoutine == null)
            shootRoutine = StartCoroutine(Shoot());
    }

    public void StopShooting()
    {
        Shooting = false;
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            //TODO
            if (!OneShoot())
            {
                break;
            }
            yield return new WaitForSeconds(.5f);
            if (Shooting == false)
            {
                shootRoutine = null;
                break;
            }
        }
    }
}
