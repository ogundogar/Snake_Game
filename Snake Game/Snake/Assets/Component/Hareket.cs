using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Hareket : MonoBehaviour
{

    public float Hýz;
    Vector3 konum;
    public GameObject yýlan;
    List<GameObject> govde = new List<GameObject>();


    Vector3 eski_pozisyon;
    GameObject cýkarýlan;

    void düz_hareket()
    {
        eski_pozisyon = GameObject.Find("Yýlan").GetComponent<Transform>().position;
        GameObject.Find("Yýlan").GetComponent<Transform>().Translate(1.0f * Hýz, 0, 0);
        if (govde.Count > 0)
        {
            govde[0].transform.position = eski_pozisyon;
            cýkarýlan = govde[0];
            govde.RemoveAt(0);
            govde.Add(cýkarýlan);
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
          
            GameObject.Find("Yýlan").GetComponent<Transform>().Rotate(0,90,0);
            InvokeRepeating("düz_hareket", 0.0f, 0.10f);
               
        }
        
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CancelInvoke();
       
            GameObject.Find("Yýlan").GetComponent<Transform>().Rotate(0, -90, 0);
            InvokeRepeating("düz_hareket", 0, 0.10f);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CancelInvoke();
            InvokeRepeating("düz_hareket", 0, 0.10f);
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
        govde.Add(Instantiate(yýlan, new Vector3(90,90,90), Quaternion.identity));
        
        
    }

}
