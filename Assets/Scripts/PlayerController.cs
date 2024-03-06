using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 5f;
    public float movespeed = 5f;


    // Start is called before the first frame update

    public float moveSpeed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log(horizontalInput);

        Vector3 movement = Vector3.right * horizontalInput;

        float verticalInput = Input.GetAxis("Vertical");

        movement += Vector3.forward * verticalInput;

        movement = movement.normalized;

        movement *= Time.deltaTime;

        movement *= moveSpeed;

        transform.position += movement;


    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }
    void Jump()
    {
        if (transform.position.y <= Mathf.Epsilon)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    //1198991e1e1e1
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("BOOM");
    }
}