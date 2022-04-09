using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour
{
    private float coin = 0;
    public Text CoinText;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {
            coin++;
            CoinText.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
