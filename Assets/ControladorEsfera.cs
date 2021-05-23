using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEsfera : MonoBehaviour
{

	public float speed;    

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
	float vertical = Input.GetAxis("Vertical");

	Vector3 direction = new Vector3(horizontal, 0, vertical);

	GetComponent<Rigidbody>().AddForce(direction * speed);
    }
}
