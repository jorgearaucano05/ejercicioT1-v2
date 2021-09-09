using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class NinjaController : MonoBehaviour
{

    public float velocityX = 10;
    public float jumpforce = 50;
    
    private Rigidbody2D rb;

    private Animator _animator;

    private bool gameRunning;
    private bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
        _animator.SetInteger("Estado",0);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.up*jumpforce,ForceMode2D.Impulse);
            _animator.SetInteger("Estado",1);
        }
    }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Zombie")
        {
            Debug.Log("Collision: "+collision.gameObject.name);
        }
        
        else if (collision.gameObject.CompareTag("Enemigo"))
        {
            isDead = true;
            _animator.SetInteger("Estado",-1);
            Time.timeScale = 0f;
        }
        
    }

    private void ChangeGameRunningState()
    {
        gameRunning = !gameRunning;
    }
}
