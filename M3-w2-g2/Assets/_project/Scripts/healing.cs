using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healing : MonoBehaviour
{
    [SerializeField] private int amount;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var comp = other.GetComponent<health>();
        if (comp != null)
        {
            comp.Takeheal(amount);
            Destroy(gameObject);
        }

    }
}
