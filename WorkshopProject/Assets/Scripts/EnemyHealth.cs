using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float initialHealth;
    private float currentHealth;

    void Start()
    {
        currentHealth = initialHealth;
    }

    public void ApplyDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Debug.Log("Enemy Died");

            Destroy(this.gameObject);

        }
    }
}
