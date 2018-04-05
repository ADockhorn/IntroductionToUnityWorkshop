using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform spawnPos;
    public Bullet bulletPrefab;
    public int ammo = 5;
    public int maxAmmo = 10;
    public float coolDownTimer = 1;

    private float internTimer = 0;
    private bool fireRdy = true;

    private void Awake()
    {
        internTimer = 0;
        fireRdy = true;
    }

    private void Update()
    {
        if (!fireRdy)
        {
            internTimer += Time.deltaTime;
            if (internTimer >= coolDownTimer)
            {
                internTimer = 0;
                fireRdy = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && fireRdy)
        {
            ammo--;
            if (ammo < 0)
            {
                ammo = 0;
                Debug.Log("Not enough ammo");
                return;
            }
            Debug.Log("Ammo: " + ammo);
            Bullet a = Instantiate(bulletPrefab, spawnPos.transform.position,new Quaternion(this.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z, 0),null);
            a.Init((spawnPos.transform.position - this.transform.position).normalized);
            fireRdy = false;
        }
    }
    public void DestroyWeapon()
    {
        Destroy(this.gameObject);
    }
    public void SetMuni(int value)
    {
        ammo += value;
        if(ammo > maxAmmo)
        {
            ammo = maxAmmo;
        }
    }


}
