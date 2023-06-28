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
            StartCoroutine("del");
        }
    }

   
    void Update()
    {
        if(rain.GetComponent<Summons>().bullet == true)
        {
            this.gameObject.transform.Translate(Vector3.forward * 0.5f);
        }



        if(this.gameObject.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
    }
    IEnumerator del()
    {
        
        yield return new WaitForSeconds(3);

        Destroy(this.gameObject);

    }
}
