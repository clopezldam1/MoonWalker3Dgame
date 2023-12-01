using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int coins = 0;
    public const int maxCoins = 10;
    public TextMeshProUGUI contadorCoins;

    private void Update()
    {
        if(coins == maxCoins)
        {
            SceneController.cambiarEscena(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coins++;
            contadorCoins.text = coins.ToString() + " / " + maxCoins.ToString();
            Destroy(other.gameObject);
        }
    }
}
