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

		public float jumpForce;
		public float jumpCoolDown;
		bool readyToJump = true;
		public KeyCode jumpKey = KeyCode.Space;

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
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
     
			if(Input.GetKey(jumpKey) && readyToJump)
			{
                print("Jump pressed 1");
                readyToJump = false;
				Jump();
				Invoke(nameof(ResetJump), jumpCoolDown);
                print("Jump pressed 2");
            }
		}

		private void Jump()
		{
			rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

			controller.Move(transform.up * jumpForce);

        }

		private void ResetJump()
		{
			readyToJump = true;
		}
	}
}
