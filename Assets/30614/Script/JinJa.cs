using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JinJa : MonoBehaviour
{
    public float Max;
    public float Min;
    public float Speed;
    public Direction dir;

    int x, z;

    void Start()
    {
        if(Direction.x == dir)
        {
            x = 1;
            z = 0;
        }
        else if(dir == Direction.z)
        {
            x = 0;
            z = 1;
        }
        else
        {
            x = 0;
            z = 0;
        }
    }

    
    void Update()
    {
        this.gameObject.transform.Rotate(new Vector3(x * Speed * Time.deltaTime, 0, z * Speed * Time.deltaTime));

        if (RoundAngle2(this.gameObject.transform.localEulerAngles.x) >= Max || RoundAngle2(this.gameObject.transform.localEulerAngles.z) >= Max) // Max에 도착했을때
        {
            x = -x;
            z = -z;
        }
        else if(RoundAngle2(this.gameObject.transform.localEulerAngles.x) <= Min || RoundAngle2(this.gameObject.transform.localEulerAngles.z) <= Min) // Min에 도착했을떄
        {
            x = -x;
            z = -z;
        }
    }


    float RoundAngle2(float angle)
    {
        angle %= 360;
        if (angle > 180)
        {
            return angle - 360;
        }
        else if (angle < -180)
        {
            return angle + 360;
        }
        else
        {
            return angle;
        }
    }

    public enum Direction
    {
        None = 0,
        x = 1,
        z = 2
    }
}



