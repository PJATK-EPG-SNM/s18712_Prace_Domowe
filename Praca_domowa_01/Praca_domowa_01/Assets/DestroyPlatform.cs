using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{

        Rigidbody2D rbd;

        void Start()
        {
            rbd = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Equals("Player"))
            {
                Destroy(gameObject, 2);
            }
        }

        void Destroy()
        {
            rbd.isKinematic = false;


        }
    }
