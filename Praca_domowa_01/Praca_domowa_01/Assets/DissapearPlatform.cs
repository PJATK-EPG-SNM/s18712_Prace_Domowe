using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearPlatform : MonoBehaviour
{
    Rigidbody2D rb2d;
   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Player"))
        {
            Invoke("FallPlatform", 1f);
            Destroy(gameObject, 2f);
        }
    }

    void FallPlatform()
        {
            rb2d.isKinematic = false;

            
        }
    }