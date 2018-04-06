using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject target;

    public float cooldown = 1.0f;

    public int minSpawns = 0;
    public int maxSpawns = 2;

    [Range(0.0f, 1.0f)]
    public float chance = 0.5f;

    public GameObject[] enemyPrefabs;
    private float curCooldown = 0.0f;


	// Use this for initialization
	void Start () {
        curCooldown = cooldown;
	}
	
	// Update is called once per frame
	void Update () {

        curCooldown -= Time.deltaTime;

        if(curCooldown <= 0.0f)
        {
            if(Random.value <= chance)
                Spawn();

            curCooldown = cooldown;
        }

	}

    private void Spawn()
    {
        int numSpawns = Random.Range(minSpawns, maxSpawns + 1);

        for (int i = 0; i < numSpawns; i++)
        {
            int index = Random.Range(0, enemyPrefabs.Length);
            var curPrefab = enemyPrefabs[index];


            Vector2 startPos = transform.position;
            startPos += Random.insideUnitCircle * 0.25f;

            var instance = Instantiate(curPrefab, startPos, Quaternion.identity);

            var enemyMovement = instance.GetComponent<EnemyMovement>();

            if(enemyMovement)
            {
                enemyMovement.target = target;
            }
        }
    }
}
