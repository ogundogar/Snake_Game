using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class YEM : MonoBehaviour
{


    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "YılanGövdesi")
        {

            float rndX = Random.Range(-50.0f, 50.0f);
            float rndZ = Random.Range(-40.0f, 40.0f);
            GameObject.Find("Yem").GetComponent<Transform>().position = new Vector3(rndX, 0.0f, rndZ);
            
        }

    }
  
    

    
   


}
