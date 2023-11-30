using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player")) 
        {
            Destroy(gameObject); //hacer desaparecer la moneda cuando el player la toca
            ContadorCoin.coinsCollected += 1;
            ContadorCoin contador = new ContadorCoin();
            contador.anadirMonedaContador();
        }
    }
}
