using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float yZoom = .6f;
    public float zZoom = .1f;

    public int tilt = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if(transform.position.y >= 1)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - yZoom, transform.position.z + zZoom);
                transform.Rotate(-tilt, 0, 0);
            }
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (transform.position.y <= 8)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + yZoom, transform.position.z - zZoom);
                transform.Rotate(tilt, 0, 0);
            }
        }

    }
}
