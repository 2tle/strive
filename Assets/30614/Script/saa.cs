using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saa : MonoBehaviour
{
    public float angle;
    [SerializeField] bool positive = true;
    float time;
    [SerializeField] float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        angle = transform.localEulerAngles.x;


    }

    // Update is called once per frame
    void Update()
    {
        if (RoundAngle2(transform.localEulerAngles.x) > 69.5)
        {
            speed = 1;

        }
        else if (RoundAngle2(transform.localEulerAngles.x) < -69.5)
        {
            speed = 1;

        }
        else
        {
            speed = 0.35f;
        }


        time += Time.deltaTime * speed;

        if (time > 1)
        {
            time = 0;
            positive = !positive;
        }

        float newAngle = Mathf.LerpAngle(transform.localEulerAngles.x, positive ? 70 : -70 , time);
        transform.localEulerAngles = Vector3.right * newAngle;


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
}
