using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public float Up;


    void Start()
    {
        
    }

    
    void Update()
    {
        WariGari();
    }

    //ÃßÀû, ¿Ô´Ù°¬´Ù, ·£´ý

    void WariGari()
    {
        this.gameObject.transform.Translate(0, Up * Time.deltaTime, Speed * Time.deltaTime);    
    }



    public enum Direction
    {
        None = 0,
        WariGari = 1,
        Follow = 2,
        Randomu = 3,
    }

}
