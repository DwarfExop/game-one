using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [Range(1,20)]
    public float JumpStrength = 10;
    private bool canJump = true;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump)
            {
                Debug.Log("Memebeer");
                GetComponent<Rigidbody>().AddForce(Vector3.up * JumpStrength, ForceMode.Impulse);
                canJump = false;
            }

        }
	}

    void OnCollisionEnter(Collision collision)
    {
        print("Collision");
        canJump = true;
    }
}
