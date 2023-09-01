using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float verticalInput;

    public GameObject playerProjectile;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -11)
        {
            transform.position = new Vector3(-11f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 11)
        {
            transform.position = new Vector3(11f, transform.position.y, transform.position.z);
        }

        if (transform.position.z > 15)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 15f);
        }

        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(playerProjectile, transform.position, playerProjectile.transform.rotation);
        }
        
    }
}
