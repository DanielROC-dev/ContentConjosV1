using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Vector3 startForce;
    private Rigidbody Rb;
    public float maxSpeed = 20f;
  
    // Start is called before the first frame update
    void Start()
    {
        startForce = new Vector3(Random.Range(1, 10), Random.Range(1,10), 0);
        Rb = GetComponent<Rigidbody>();
        Rb.AddForce(startForce, ForceMode.Impulse);
    }

    void FixedUpdate() {
        if(Rb.velocity.magnitude > maxSpeed){
            Rb.velocity = Vector3.ClampMagnitude(Rb.velocity, maxSpeed);
        }
    }

}
