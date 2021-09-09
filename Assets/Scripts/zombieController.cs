using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class zombieController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float jumpforce = 50;
    
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(Vector2.up*jumpforce,ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Suelo")
        {
            Debug.Log("Collision: "+collision.gameObject.name);
            rb.AddForce(Vector2.up*jumpforce,ForceMode2D.Impulse);
        }
    }
}
