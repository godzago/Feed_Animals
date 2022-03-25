using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    private float puan;
    public Text puanText;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collected")
        {
            puan += 1;
            puanText.text = puan.ToString();
        }      
    }
}
