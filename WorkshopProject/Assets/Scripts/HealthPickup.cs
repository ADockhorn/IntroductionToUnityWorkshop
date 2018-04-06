using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float health = 10.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

        if (playerHealth)
        {
            playerHealth.AddHealth(health);
            Destroy(gameObject);
        }
    }
}
