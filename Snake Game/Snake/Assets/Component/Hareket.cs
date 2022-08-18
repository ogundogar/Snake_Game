using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Hareket : MonoBehaviour
{

    public float H�z;
    Vector3 konum;
    public GameObject y�lan;
    List<GameObject> govde = new List<GameObject>();


    Vector3 eski_pozisyon;
    GameObject c�kar�lan;

    void d�z_hareket()
    {
        eski_pozisyon = GameObject.Find("Y�lan").GetComponent<Transform>().position;
        GameObject.Find("Y�lan").GetComponent<Transform>().Translate(1.0f * H�z, 0, 0);
        if (govde.Count > 0)
        {
            govde[0].transform.position = eski_pozisyon;
            c�kar�lan = govde[0];
            govde.RemoveAt(0);
            govde.Add(c�kar�lan);
        }
    }



    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            CancelInvoke();
          
            GameObject.Find("Y�lan").GetComponent<Transform>().Rotate(0,90,0);
            InvokeRepeating("d�z_hareket", 0.0f, 0.10f);
               
        }
        
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CancelInvoke();
       
            GameObject.Find("Y�lan").GetComponent<Transform>().Rotate(0, -90, 0);
            InvokeRepeating("d�z_hareket", 0, 0.10f);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CancelInvoke();
            InvokeRepeating("d�z_hareket", 0, 0.10f);
        }


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Yem")
        {
            govd();
           
        }

    }
    public void govd()
    {
        govde.Add(Instantiate(y�lan, new Vector3(90,90,90), Quaternion.identity));
        
        
    }

}
