using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public Transform _planePropellor;
    public float propellorSpeed;
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        _planePropellor.Rotate(Vector3.forward * propellorSpeed * Time.deltaTime);
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
