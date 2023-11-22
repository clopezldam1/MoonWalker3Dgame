using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
	float moveSpeed = 10;
	public Transform cam;
	
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update()
	{
		// Inputs
		float horInput = Input.GetAxisRaw("Horizontal") * moveSpeed;
		float verInput = Input.GetAxisRaw("Vertical") * moveSpeed;
		
		// Camera dir
		Vector3 camForward = cam.forward;
		Vector3 camRight = cam.right;
		
		camForward.y = 0;
		camRight.y = 0;
		
		// Creating relate cam direction
		Vector3 forwardRelative = verInput * camForward; //hacia donde mira la cámara (profundidad - front/back DE LA CAMARA)
		Vector3 rightRelative = horInput * camRight; //posición cámara en el plano (derecha/izquierda DE LA CAMARA)
		
		// Movement
		Vector3 moveDir = forwardRelative + rightRelative;
		// OLD
		// rb.velocity = new Vector3(horInput, rb.velocity.y, verInput);
		rb.velocity = new Vector3(moveDir.x, rb.velocity.y, moveDir.z);
		
		transform.forward = new Vector3(rb.velocity.x, 0, rb.velocity.z);
	}
}
