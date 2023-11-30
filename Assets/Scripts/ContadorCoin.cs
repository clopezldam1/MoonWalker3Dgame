using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorCoin : MonoBehaviour
{
    public static int coinsCollected = 0;
    //[SerializeField] public GameObject[] coinsStillInMap;
    private GameObject[] coinsStillInMap;
    // public GameObject contadorHudBox;
    public static int totalCoinsInMap;
    TextMeshPro textoContador;

    // Start is called before the first frame update
    void Start()
    {
        textoContador = GetComponent<TextMeshPro>();
        coinsStillInMap = GameObject.FindGameObjectsWithTag("Coin");
        totalCoinsInMap = coinsStillInMap.Length;
        print(totalCoinsInMap);
        anadirMonedaContador();
    }

    public void anadirMonedaContador()
    {
        //textoContador.SetText(coinsCollected + "/" + totalCoinsInMap);
        textoContador.text = coinsCollected + " / " + totalCoinsInMap;
    }

}
