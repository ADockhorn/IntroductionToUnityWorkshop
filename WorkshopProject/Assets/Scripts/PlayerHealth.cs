using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour {

    public float initialHealth;

    float currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = initialHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ApplyDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth < 0)
        {
            Debug.Log("Player Died");

            // this allows us to test stuff easier!
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
