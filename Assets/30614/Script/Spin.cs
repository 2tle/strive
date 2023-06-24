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
        switch(dir)
        {
            case Direction.X:
                this.gameObject.transform.Rotate(new Vector3(spinDirection * spinSpeed * Time.deltaTime, 0, 0));
                break;
            case Direction.Y:
                this.gameObject.transform.Rotate(new Vector3(0, spinDirection * spinSpeed * Time.deltaTime, 0));
                break;
            case Direction.Z:
                this.gameObject.transform.Rotate(new Vector3(0, 0, spinDirection * spinSpeed * Time.deltaTime));
                break;
        }

        


    }


    public enum Direction
    {
        None = 0,
        X = 1,
        Y = 2,
        Z = 3,
    }
}
