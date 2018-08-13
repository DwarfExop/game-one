using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float movementSpeed = 5.0f;
    public float rotSpeed = 10;
    public GameObject destination;
    public float checkRadius = 5f;

    Vector3 targetPosition;
    bool moving = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }
        if (moving) Move();

        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);


    }

    void SetTargetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {
            Vector3 hitMarker = hit.point;
            destination.SetActive(true);
            targetPosition = hit.point;
            destination.transform.position = new Vector3(targetPosition.x, targetPosition.y + 0.2f, targetPosition.z);

            moving = true;
        }
    }

    void Move()
    {
        Vector3 lookAtTarget = new Vector3(targetPosition.x - transform.position.x, transform.position.y, targetPosition.z - transform.position.z);
        Quaternion playerRot = Quaternion.LookRotation(lookAtTarget);

        transform.rotation = Quaternion.Slerp(transform.rotation, playerRot, rotSpeed * Time.deltaTime);

        transform.position = Vector3.MoveTowards(transform.position, 
                                                 targetPosition, 
                                                 movementSpeed * Time.deltaTime);
        
        if ((transform.position - destination.transform.position).magnitude < checkRadius)
        {
            moving = false;
            destination.SetActive(false);
        }
    }
}
