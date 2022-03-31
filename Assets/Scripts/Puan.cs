using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    private int puan;
    public Text puanText;
    void Start()
    {
        puan.ToString();
      //  puan = GameObject.FindGameObjectsWithTag("ScoreManager");
    }
    void Update()
    {
        puanText.text = puan.ToString();
    }
  

}
