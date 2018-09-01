using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour
{

    // Use this for initialization
    Vector3 velocity = new Vector3(0.3f, 0.5f, 0f);
    Vector3 gravity = new Vector3(0f, -0.05f, 0f);

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity += gravity;
        transform.position += velocity;

        if (transform.position.y <= -3)
        {
            if(velocity.y <= 0)
            {
                velocity.y *= -1.1f;
                if(transform.position.y > 7)
                {
                    velocity.y = -1f;
                }
            }
        }


        if(transform.position.x > 8.5)
        {
            velocity.x *= -1f;
        }

        if (transform.position.x < -8.5)
        {
            velocity.x = 0.05f;
        }



        Debug.Log(transform.position.y);
    }
}
