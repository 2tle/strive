using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 10;
    public int jumpCount = 0;
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
        Debug.Log("jump");
        if(Input.GetKey(KeyCode.Space) && jumpCount == 0)
        {
            Debug.Log("if");
            //rigid.velocity = Vector3.zero;
            rigid.AddForce(Vector3.up * jumpPower);
            jumpCount++;
        }
        else if(Input.GetKey(KeyCode.Space) && jumpCount == 1)
        {
            rigid.velocity = Vector3.zero;
            rigid.AddForce(Vector3.up * jumpPower);
            jumpCount++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("´ê¾Ò¾î");
        if(collision.gameObject.tag == "Floor")
        {
            jumpCount = 0;
        }
    }
}
