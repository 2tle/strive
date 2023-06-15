using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 10;
    int jumpCount;
    bool isGraund;
    public float jumpPower;

    float x;
    float z;

    Rigidbody rigid;



    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Move();
        Jump();
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
        if(Input.GetKey(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower * Time.deltaTime, ForceMode.Impulse);
        }
        
    }
}
