using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    GameObject rain;
    
    void Start()
    {
        rain = GameObject.Find("Rain");
        if (rain.GetComponent<Summons>().bullet == true)
        {
            this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

   
    void Update()
    {
        if(rain.GetComponent<Summons>().bullet == true)
        {
            this.gameObject.transform.Translate(Vector3.forward * 1f);
        }



        if(this.gameObject.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
