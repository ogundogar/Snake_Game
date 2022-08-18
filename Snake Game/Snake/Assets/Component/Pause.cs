using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool oyun_durdumu = false;
    public GameObject durdu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            oyun_durdumu = !oyun_durdumu;
            if (oyun_durdumu == true)
            {
                durdu.SetActive(true);
                Time.timeScale = 0.0f;
                Debug.Log("Oyun durdu");

            }
            else
            {
                durdu.SetActive(false);
                Time.timeScale = 1.0f;
                Debug.Log("Oyun çalýþýyor");
            }
        }
    }
    public void Durdurma()
    {
        oyun_durdumu = !oyun_durdumu;
        if (oyun_durdumu == true)
        {
            Time.timeScale = 0.0f;
            durdu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            durdu.SetActive(false);
        }
    }

   
}
