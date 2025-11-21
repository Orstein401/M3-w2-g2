using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Rigidbody2D _rb;
    Vector2 dir;
   

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
       dir= new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       
       if (dir.magnitude > 1)
        {
           dir= dir/ Mathf.Sqrt(dir.magnitude);
        }
       

    }
    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + dir * (speed * Time.deltaTime));
        
    }
}
