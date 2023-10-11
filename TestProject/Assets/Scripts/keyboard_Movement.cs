using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class keyboard_Movement : MonoBehaviour
{
    float _xmove;
    float _ymove;
    Rigidbody2D _rb;
    float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();  
    }

    void CheckInput()
    {
        _xmove = Input.GetAxis("Horizontal");
        _ymove = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
       _rb.AddForce(new Vector2(_xmove, _ymove) * speed);
    }

}
