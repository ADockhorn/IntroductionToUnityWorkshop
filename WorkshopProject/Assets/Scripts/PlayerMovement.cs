using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float horMovement = Input.GetAxis("Horizontal");
        float verMovement = Input.GetAxis("Vertical");

        Vector3 currentPosition = this.transform.position;
        this.transform.position = new Vector3(
            currentPosition.x + horMovement * speed * Time.deltaTime, 
            currentPosition.y + verMovement * speed * Time.deltaTime, 
            currentPosition.z);
    }
}
