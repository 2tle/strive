using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarajinda : MonoBehaviour
{
   
    void Start()
    {
            
    }

    
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //�������
            StartCoroutine("SakJe");
        }
    }

    IEnumerator SakJe()
    {
        yield return new WaitForSeconds(3);

        Destroy(this.gameObject);
    }
}
