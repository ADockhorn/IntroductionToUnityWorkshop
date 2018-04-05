using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float damage;
    public float coolDown;

    float currentCoolDown;

    // Use this for initialization
    void Start()
    {
        currentCoolDown = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentCoolDown > 0)
            currentCoolDown -= Time.deltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (currentCoolDown <= 0 && collision.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<PlayerHealth>().ApplyDamage(damage);
            Debug.Log("Attacking Player!");
            currentCoolDown = coolDown;
        }
    }
}
