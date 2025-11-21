using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] int vita=5;

    public void TakeDamage(int damage)
    {
        vita -= damage;
        Debug.Log("vita sta a " + vita);
        if(vita <= 0)
        {
            Debug.Log("morto");
            Destroy(gameObject);
        }
    }
    public void Takeheal(int amount)
    {
        if (vita <= 0)
        {
            Debug.Log("morto");
            Destroy(gameObject);
        }
        else
        {
            vita += amount;
            Debug.Log("vita sta a " + vita);
        }
       
        
    }
}
