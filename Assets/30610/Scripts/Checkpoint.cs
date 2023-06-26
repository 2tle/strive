using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetFloat("CP_X", other.transform.position.x);
        PlayerPrefs.SetFloat("CP_Y", other.transform.position.y);
        PlayerPrefs.SetFloat("CP_Z", other.transform.position.z);

        Debug.Log("CheckPoint: " + other.transform.position.ToString());
    }
}
