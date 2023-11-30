using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int coins = 0;
    public TextMeshProUGUI contadorCoins;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coins++;
            contadorCoins.text = coins.ToString() + " / 10";
            print(coins);
            Destroy(other.gameObject);
        }
    }
}
