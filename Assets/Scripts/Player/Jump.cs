using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    public float JumpStrength = 10;

    private bool canJump = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Memebeer");
            GetComponent<Rigidbody>().AddForce(Vector3.up * JumpStrength,ForceMode.Impulse);
        }
	}

}
