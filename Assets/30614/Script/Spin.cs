using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float spinSpeed;
    public int spinDirection;

    public Direction dir;

    void Start()
    {
        
    }

    
    void Update()
    {
        Spinning();
    }

    void Spinning()
    {
        

        this.gameObject.transform.Rotate(new Vector3(0, spinDirection * spinSpeed * Time.deltaTime, 0));


    }


    public enum Direction
    {
        None = 0,
        Left = 1,
        Right = -1,
    }
}
