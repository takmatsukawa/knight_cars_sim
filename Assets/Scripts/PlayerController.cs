using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 40;
    public float turnSpeed;
    public float horizontalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
