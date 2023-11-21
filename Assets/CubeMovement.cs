using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 3;
    private Rigidbody playerRb;
    private Vector3 moveInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Jump");
        float moveZ = Input.GetAxisRaw("Vertical");
        moveInput = new Vector3(moveX, moveY, moveZ).normalized; //.normalized para que en diagonal vaya a misma velocidad que en otras direcciones
        playerRb.AddForce(moveInput);
        //playerRb.AddForce(moveInput);   
    }
}
