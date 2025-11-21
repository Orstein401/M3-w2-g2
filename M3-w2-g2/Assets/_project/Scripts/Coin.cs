using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var comp= collision.GetComponent<CoinHolder>();
        if (comp)
        {
            comp.coin += 1;
            Debug.Log("le monete sono " + comp.coin);
        }
        Destroy(gameObject);
    }
}
