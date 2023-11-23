using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    //[SerializeField] private GameObject coin;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player")) 
        {
            Destroy(gameObject); //hacer desaparecer la moneda cuando el player la toca
            ContadorCoin.coinsCollected += 1;
            ContadorCoin.anadirMonedaContador();
        }
    }

  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
