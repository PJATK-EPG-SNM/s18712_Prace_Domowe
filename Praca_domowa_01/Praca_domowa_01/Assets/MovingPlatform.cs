using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.4f, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
        if (transform.position.x > -2)
        {
            speed = -speed;
        }
        if (transform.position.x < -3.5)
        {
            speed = Random.Range(0.4f, 2);
        }
    }

}

