using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Rigidbody2D _rb;
   
    Vector2 Velocity;
   

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
       Velocity= new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       
       if (Velocity.magnitude > 1)
        {
           
            Velocity = Velocity.normalized;
        }
       

    }
    void FixedUpdate()
    {
        
        _rb.velocity = Velocity*speed;
        
    }
}
