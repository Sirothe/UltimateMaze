using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBallMovement : MonoBehaviour
{

    private Rigidbody rb;
    private float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * speed,rb.velocity.y,verticalInput * speed);
    }
}
