using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summons : MonoBehaviour
{
    public style sy;

    public GameObject StartPos;
    public GameObject EndPos;
    public float YPos;

    public GameObject BeSummoned;

    public bool bullet;

    Vector3[] RandPos = new Vector3[3];
    Vector3 Pos1;
    Vector3 Pos2;

    void Start()
    {
        switch(sy)
        {
            case style.rain:
                Pos1 = StartPos.transform.position;
                Pos2 = EndPos.transform.position;
                StartCoroutine("Rain");
                break;
            case style.shot:
                Pos1 = StartPos.transform.position;
                StartCoroutine("Shot"); 
                break;
        }

        
    }

    
    void Update()
    {
        
    }

    IEnumerator Rain()
    {
        for(int i = 0; i < 3; i++)
        {
            RandPos[i] = new Vector3(Random.Range(Pos1.x, Pos2.x), YPos, Random.Range(Pos1.y, Pos2.y));
        }

        for (int i = 0; i < 3; i++)
        {
            var obj = Instantiate(BeSummoned, RandPos[i], this.gameObject.transform.rotation);
            obj.transform.localScale = Vector3.one * Random.Range(1, 10);
        }

        yield return new WaitForSeconds(5);
        StartCoroutine("Rain");
    }

    IEnumerator Shot()
    {
        var obj = Instantiate(BeSummoned, Pos1, this.gameObject.transform.rotation);

        yield return new WaitForSeconds(5);
        StartCoroutine("Shot");
    }

    public enum style
    {
        None = 0,
        rain = 1,
        shot = 2,
    }    
}
