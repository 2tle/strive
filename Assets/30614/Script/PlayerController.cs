using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 10;
    int jumpCount;
    bool isGraund;
    float jumpPower;

    float x;
    float z;



    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        transform.Translate(x * playerSpeed *Time.deltaTime, 0, 0);
        transform.Translate(0, 0, z * playerSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        //rigidbody.AddForce(Vector3.up * jumpPower * Time.deltaTime);
    }
}
