using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int amount;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var comp= collision.GetComponent<CoinHolder>();
        if (comp)
        {
            comp.coin += amount;
            Debug.Log("le monete sono " + comp.coin);
        }
        Destroy(gameObject);
    }
}
