using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool IsPlayer1;
    
    public float speedPlayer;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    
    
    void Update()
    {
        if (IsPlayer1)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * Time.deltaTime * speedPlayer * verticalInput);
            transform.Rotate(Vector3.up,turnSpeed * Time.deltaTime * horizontalInput);    
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal1");
            verticalInput = Input.GetAxis("Vertical1");
            transform.Translate(Vector3.forward * Time.deltaTime * speedPlayer * verticalInput);
            transform.Rotate(Vector3.up,turnSpeed * Time.deltaTime * horizontalInput);    
        }
        
    }
}
