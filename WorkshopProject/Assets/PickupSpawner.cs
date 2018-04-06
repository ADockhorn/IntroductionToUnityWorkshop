using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{   
    public float cooldown = 10.0f;
    public float duration = 10.0f;

    public List<GameObject> prefabs;

    private float curDuration = 0.0f;
    private float curCooldown = 0.0f;
    private GameObject instance;

    private void Start()
    {
        curCooldown = cooldown * Random.value;
    }

    private void Update()
    {
        if (instance != null)
        {
            curDuration -= Time.deltaTime;

            if(curDuration <= 0.0f)
            {
                Destroy(instance);
            }
        }

        else
        {
            if (curCooldown > 0.0f)
            {
                curCooldown -= Time.deltaTime;

                if (curCooldown <= 0.0f)
                {
                    instance = Instantiate(prefabs[Random.Range(0, prefabs.Count)], transform.position, Quaternion.identity);
                    curCooldown = cooldown;
                    curDuration = duration;
                }
            }
        }
    }
}
