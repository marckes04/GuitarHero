using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.velocity = new Vector2(0,-Speed);
    }

    void Update()
    {
        
    }
}
