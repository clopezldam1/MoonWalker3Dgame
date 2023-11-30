using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

namespace AstronautPlayer
{

	public class AstronautPlayer : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;
	
		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;
		private Rigidbody rb;

		void Start () {
			controller = GetComponent<CharacterController>();
			anim = GetComponent<Animator>();
			rb = GetComponent<Rigidbody>();
		}

		void Update()
		{
			if (Input.GetKey("w") || Input.GetKey("s"))
			{
				anim.SetInteger("AnimationPar", 1);
			}
			else
			{
				anim.SetInteger("AnimationPar", 0);
			}

			float turn = Input.GetAxis("Horizontal");
			moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			//controller.Move(moveDirection * Time.deltaTime);
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
            rb.AddForce(moveDirection * Time.deltaTime);
			

			/*if (Input.GetKeyDown(KeyCode.Space))
			{
				float jumpDistance = 100f;
                moveDirection = transform.up * Input.GetAxis("Jump") * jumpDistance;
                controller.Move(moveDirection * Time.deltaTime);
            }*/
		}
	}
}
