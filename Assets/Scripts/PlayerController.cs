using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public float zRange = -9.99f;
    public GameObject foodProjectile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodProjectile, transform.position+ new Vector3(0,0,3), foodProjectile.transform.rotation);
        }
        if (transform.position.x< -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRange+6)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange + 6);
        }
        if (transform.position.z < zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
