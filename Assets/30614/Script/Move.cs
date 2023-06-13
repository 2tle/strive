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

    [Serializable]
    public class _2dArray
    {
        public GameObject[] arr = new GameObject[2];
    }

   
    public _2dArray[] posX_Y = new _2dArray[5];

    Vector3 StartPos;
    Vector3 EndPos;
    

    void Start()
    {
        StartPos = posX_Y[ObstacleNum].arr[0].transform.position;
        EndPos = posX_Y[ObstacleNum].arr[1].transform.position;

        //만약 와리가리면
        this.gameObject.transform.position = StartPos;

        this.gameObject.transform.LookAt(EndPos);

        StartCoroutine("WariGari2");
    }

    
    void Update()
    {
        //WariGari();
    }

    //추적, 왔다갔다, 랜덤

    void WariGari()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, EndPos, Speed * Time.deltaTime);

        //this.gameObject.transform.Translate(0, Up * Time.deltaTime, Speed * Time.deltaTime);
        
    }


    IEnumerator WariGari2()
    {
        while(this.gameObject.transform.position != EndPos)
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
