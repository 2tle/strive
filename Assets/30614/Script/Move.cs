using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public float Up;
    public int ObstacleNum;

    //public GameObject[,] pos;

    public GameObject startpos;
    public GameObject endpos;

    Vector3 StartPos;
    Vector3 EndPos;
    

    void Start()
    {
        StartPos = startpos.transform.position;
        EndPos = endpos.transform.position;

        //만약 와리가리면
        this.gameObject.transform.position = StartPos;

        //this.gameObject.transform.LookAt(EndPos);

        StartCoroutine("WariGari2");
    }

    IEnumerator WariGari2()
    {
        yield return new WaitForSeconds(3);

        while (this.gameObject.transform.position != EndPos)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, EndPos, Speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(3);

        while (this.gameObject.transform.position != StartPos)
        {
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, StartPos, Speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }

        StartCoroutine("WariGari2");
    }



    public enum Direction
    {
        None = 0,
        WariGari = 1,
        Follow = 2,
        Randomu = 3,
    }

}
