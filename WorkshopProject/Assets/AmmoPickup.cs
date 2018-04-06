using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

    [Range(0.0f, 1.0f)]
    public float ammoPercent = 0.25f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var weaponSpawner = collision.gameObject.GetComponent<WeaponSpawner>();

        if (weaponSpawner)
        {
            int addAmmo = (int)(weaponSpawner.curWeaponInstance.maxAmmo * ammoPercent);
            weaponSpawner.curWeaponInstance.AddMuni(addAmmo);
            Destroy(gameObject);
        }
    }
}
