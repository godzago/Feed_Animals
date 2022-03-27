using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    private float puan;
    public Text puanText;
    public GameObject[] Cube;

    private void Start()
    {
        if (Cube == null)
            Cube = GameObject.FindGameObjectsWithTag("Coin");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            puan += 1;
            puanText.text = puan.ToString();
        }
    }
}
