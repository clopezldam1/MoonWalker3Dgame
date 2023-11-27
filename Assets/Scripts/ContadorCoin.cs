using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorCoin : MonoBehaviour
{
    public static int coinsCollected = 0;
    [SerializeField] public GameObject[] coinsStillInMap;
    [SerializeField] public GameObject contadorHudBox;
    public static int totalCoinsInMap;
    static TextMeshPro textoContador;

    // Start is called before the first frame update
    void Start()
    {
        textoContador = contadorHudBox.GetComponent<TextMeshPro>();
        totalCoinsInMap = coinsStillInMap.Length;
        anadirMonedaContador();
    }

    public static void anadirMonedaContador()
    {
        textoContador.text = coinsCollected + "/" + totalCoinsInMap;
    }

    /*
    public static int getCoinsCollected()
    {
        return coinsCollected;
    }

    public static int getTotalCoinsInMap()
    {
        return totalCoinsInMap;
    }
    */

}
