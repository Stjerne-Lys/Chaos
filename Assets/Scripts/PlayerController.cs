using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 10.0f;
    private float rotationSpeed = 200.0f;
    private float horizontalInput;
    private float movementInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        movementInput = Input.GetAxis("Vertical");
        //movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * movementInput);
        transform.Rotate(Vector3.up, rotationSpeed * horizontalInput * Time.deltaTime);
       
    }
}
