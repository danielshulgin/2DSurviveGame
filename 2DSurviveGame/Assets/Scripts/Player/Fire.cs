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
    Coroutine shootingRoutine;
    public bool Shooting { get; private set; }

    public InputManager input;

    private void Awake()
    {
        input = new InputManager();
        input.Player.Shoot.performed += context =>
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
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
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
        shootingRoutine = StartCoroutine(Shoot());
    }

    public void StopShooting()
    {
        Shooting = false;
        StopCoroutine(shootingRoutine);
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

        }
    }
}
