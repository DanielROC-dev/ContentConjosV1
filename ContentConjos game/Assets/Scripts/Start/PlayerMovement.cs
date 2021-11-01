using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D RB;
   
    private float runSpeed = 3f;
    private float jumpSpeed = 250f;
    private float horizontalInput;
    
    
  
    void Start() {
        RB = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * runSpeed;
    }

    void FixedUpdate() {
        transform.Translate(Vector3.right * Time.deltaTime * runSpeed * horizontalInput);
        
        if (Input.GetButtonDown("Jump")){
            RB.AddForce(transform.up * jumpSpeed);
        }    
    }

 
}
