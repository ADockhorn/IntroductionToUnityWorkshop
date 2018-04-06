using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour {

    public Weapon startWeaponPrefab;

    public Weapon curWeaponInstance;

	void Start () {
        curWeaponInstance = Instantiate(startWeaponPrefab, this.transform.position, Quaternion.identity, this.transform);
        
    }
     public void SetNewWeapon(Weapon weaponPrefab)
    {
        curWeaponInstance.DestroyWeapon();
        curWeaponInstance = Instantiate(weaponPrefab, this.transform.position, Quaternion.identity, this.transform);
    }
}
