using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal2");
        float y = Input.GetAxis("Vertical2");

        if (x != 0 || y != 0)
        {
            this.transform.localEulerAngles = new Vector3(0, 0, Mathf.Atan2(y, x) * 180 / Mathf.PI);
        }
	}
}
