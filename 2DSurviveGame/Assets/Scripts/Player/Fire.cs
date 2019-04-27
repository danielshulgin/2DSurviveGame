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
    }

    private void OnEnable()
    {
        input.Player.StartShoot.performed += context => StartShooting();
        input.Player.EndShoot.performed += context => StopShooting();
        input.Player.StartShoot.Enable();
        input.Player.EndShoot.Enable();
    }

    private void OnDisable()
    {
        input.Player.StartShoot.performed -= context => StartShooting();
        input.Player.EndShoot.performed -= context => StopShooting();
        input.Player.StartShoot.Disable();
        input.Player.EndShoot.Disable();
    }

    public bool OneShoot()
    {
        Item item = playerManager.inventory.items.Find(_item => _item.itemType == ItemType.Bullet);
        if (item != null && item.Use())
        {
            GameObject bullet = Instantiate(bulletPref, muzzleTransform.position, muzzleTransform.rotation);
            BulletControl bulletControl = bullet.GetComponent<BulletControl>();
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
