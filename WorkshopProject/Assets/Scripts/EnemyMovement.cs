using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed = 1;

    public GameObject target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = target.transform.position - this.transform.position;
        this.transform.position = this.transform.position + moveVector.normalized * speed * Time.deltaTime;

        if (Vector3.Distance(this.transform.position, target.transform.position) > 0.1)
            this.transform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(moveVector.y, moveVector.x) * 180 / Mathf.PI);
    }
}
