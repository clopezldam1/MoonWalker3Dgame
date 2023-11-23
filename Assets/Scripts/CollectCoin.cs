using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private MeshCollider coinTrigger;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player")) 
        {
            ContadorCoin.coinsCollected += 1;
            Destroy( gameObject ); //hacer desaparecer la moneda cuando el player la toca
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
