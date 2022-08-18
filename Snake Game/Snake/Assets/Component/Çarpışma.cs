using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Çarpışma : MonoBehaviour
{
    TMPro.TextMeshProUGUI skor;
    int Puan = 0;
    public GameObject GameOver;

    private void Start()
    {
        skor= GameObject.Find("Canvas/Skor").GetComponent<TMPro.TextMeshProUGUI>(); 
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Yem")
        {
            
            Puan = Puan+10;
            skor.text = Puan.ToString();
        }
        if (other.gameObject.tag == "Duvar")
        {
            GameOver.SetActive(true);
            Time.timeScale = 0.0f;
            Debug.Log("Oyun Bitti");
        }
    }
    public void tekrar_bttn()
    {
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}
