using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    private float vertical_Input;
    private float horizontal_Input;

    private Rigidbody rb;

    public float JumpVelocity = 5f;
    private bool isJumping;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        vertical_Input = Input.GetAxis("Vertical") * moveSpeed;
        horizontal_Input = Input.GetAxis("Horizontal") * rotateSpeed;
        isJumping |= Input.GetKeyDown(KeyCode.Space);
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * horizontal_Input;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        rb.MovePosition(this.transform.position + this.transform.forward * vertical_Input * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation * angleRot);

        if (isJumping)
        {
            rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }
        else
        {
            isJumping = false;
        }

    }

}
