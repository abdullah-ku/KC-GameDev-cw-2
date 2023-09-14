using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_Move : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed =15f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       rb.velocity = Vector2.ClampMagnitude(rb.velocity, speed); 
    }
}
