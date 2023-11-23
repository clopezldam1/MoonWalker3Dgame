using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorCoin : MonoBehaviour
{
    public static int coinsCollected = 0;
    [SerializeField] public GameObject[] coinsStillInMap;
    public static int totalCoinsInMap;
    [SerializeField] public static TextMeshPro contadorHUD;

    // Start is called before the first frame update
    void Start()
    {
        contadorHUD = GetComponent<TextMeshPro>();
        totalCoinsInMap = coinsStillInMap.Length;
    }

    public static void anadirMonedaContador()
    {
        contadorHUD.text = coinsCollected + "/" + totalCoinsInMap;
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
