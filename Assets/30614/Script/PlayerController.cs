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
    public Animator animator;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        Move();
        Jump();

        if(Input.GetKeyDown(KeyCode.R)) 
        {
            animator.SetTrigger("dance");
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            animator.SetTrigger("exit");
        }
    }

    private void Move()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        if(x != 0 || z != 0) {
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }

        transform.Translate(x * playerSpeed *Time.deltaTime, 0, 0);
        transform.Translate(0, 0, z * playerSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        //Debug.Log("jump");
        if(Input.GetKeyUp(KeyCode.Space) && jumpCount == 0)
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
        Debug.Log("��Ҿ�");
        if(collision.gameObject.tag == "Floor")
        {
            jumpCount = 0;
        }

        if(collision.gameObject.tag == "Jnag")
        {
            this.gameObject.transform.position = new Vector3(
                PlayerPrefs.GetFloat("CP_X"),
                PlayerPrefs.GetFloat("CP_Y"),
                PlayerPrefs.GetFloat("CP_Z")
            );
        }
    }

    
}
