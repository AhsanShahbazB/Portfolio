using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float horizontalInput;
    private float verticalInput;
    private float intervalColorChange = 10.0f;
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = Color.red;
    }
    
    void Update()
    {
        if (Time.time > intervalColorChange)
        {
            intervalColorChange += 10f;
            Renderer.material.color = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), 1f);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.localScale = new Vector3(transform.localScale.x + 0.01f, transform.localScale.y + 0.01f,
                transform.localScale.z + 0.01f);
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.01f, transform.localScale.y - 0.01f,
                transform.localScale.z - 0.01f);
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right,250.0f * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.forward, 250.0f * Time.deltaTime * verticalInput);
    }
}
