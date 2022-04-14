using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    private float coin = 0;
    public Text CoinText;
    ParticleSystem takeParicle;

    private void Start()
    {
        takeParicle = GameObject.Find("take").GetComponent<ParticleSystem>();
        takeParicle.Stop();
    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {
            takeParicle.transform.position = gameObject.transform.position;
            takeParicle.Play();
            coin++;
            CoinText.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
