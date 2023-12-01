using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int coins = 0;
    [SerializeField] public int maxCoins = 10;
    public TextMeshProUGUI contadorCoins;
    [SerializeField] GameObject audioManager;

    private void Start()
    {
        setContador(coins);
    }

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
            setContador(coins);
           audioManager.GetComponent<AudioManager>().PlaySfx();
            Destroy(other.gameObject);
        }
    }

    private void setContador(int coins)
    {
        contadorCoins.text = coins.ToString() + " / " + maxCoins.ToString();
    }
}
