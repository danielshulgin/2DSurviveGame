using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    PlayerMeneger playerMeneger;
    [SerializeField]
    GameObject bulletPref;
    [SerializeField]
    Transform muzzleTransform;
    [SerializeField]
    InputSystem inputSystem;
    void Start()
    {
        inputSystem.LeftButtonClick += Shot;
    }
    public void Shot()
    {
        playerMeneger.inventory.items.Find(item => item.itemType == ItemType.bullet).number -= 1;
        GameObject bullet = SimplePool.Spawn(bulletPref, muzzleTransform.position, muzzleTransform.rotation);
        BulletControl bulletControl = bullet.GetComponent<BulletControl>();
        bulletControl.shotStartDirection = transform.rotation.eulerAngles;
        bulletControl.on = true;
    }
}
