using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    
    [SerializeField] private int damage;
    health comp;
  
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        comp=other.GetComponent<health>();
        if (comp != null)
        {
           comp.TakeDamage(damage);
            Destroy(gameObject);

        }

    }
}