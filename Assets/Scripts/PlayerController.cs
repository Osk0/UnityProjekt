using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");

        Debug.Log(horizontalInput);

        Vector3 movement = Vector3.right * horizontalInput ;

        float verticalInput = Input.GetAxis("Vertical");

        movement += Vector3.forward * verticalInput ;

        movement = movement.normalized;

        movement *= Time.deltaTime;

        movement *= moveSpeed;

        transform.position += movement;
    }
}
