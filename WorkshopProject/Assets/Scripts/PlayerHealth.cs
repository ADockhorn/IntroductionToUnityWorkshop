using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour {

    public float initialHealth;

    float currentHealth;

    // Use this for initialization
    void Start()
    {
        currentHealth = initialHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddHealth(float health)
    {
        currentHealth = Mathf.Clamp(currentHealth + health, 0.0f, initialHealth);
    }

    public void ApplyDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0.0f)
        {
            currentHealth = 0.0f;

            Debug.Log("Player Died");

            // this allows us to test stuff easier!
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
