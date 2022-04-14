using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finsh : MonoBehaviour
{
    public int Puan;
    public Text PuanText;
    public void Start()
    {
        Puan = PlayerPrefs.GetInt("mypuan");
        PuanText.text = Puan.ToString();       
    }
    private void OnTriggerEnter(Collider other)
    {      
        SceneManager.LoadScene(1);
    }
}
