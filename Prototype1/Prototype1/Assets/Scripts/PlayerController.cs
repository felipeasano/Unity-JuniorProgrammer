using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este Script tem a funcao de controlar a movimentacao de um determinado objeto
// Desta forma, direcao e rotacao sao controlado pela entrada de usuario

public class PlayerController : MonoBehaviour
{
    // O caracter "f" entra no final do numero para indicar seu tipo, no caso, um "float"
    // Private Variables 
    private float speed = 10.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Rotates the car based on horizontal input
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}