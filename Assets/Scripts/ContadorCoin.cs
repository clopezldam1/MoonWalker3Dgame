using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorCoin : MonoBehaviour
{
    public static int coinsCollected = 0;
    [SerializeField] public GameObject[] coinsStillInMap;
    public static int totalCoinsInMap;

    public static int getCoinsCollected()
    {
        return coinsCollected;
    }
    public static int getTotalCoinsInMap()
    {
        return totalCoinsInMap;
    }

    // Start is called before the first frame update
    void Start()
    {
        totalCoinsInMap = coinsStillInMap.Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
