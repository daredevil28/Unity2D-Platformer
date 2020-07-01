using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight;
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private Animator _ani;
    private int _attackState;

    public int attackDamage;

    public int health;
    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _sr = gameObject.GetComponent<SpriteRenderer>();
        _ani = gameObject.GetComponent<Animator>();
    }

    void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        Jump();
        Vector3 movement = new Vector3(horizontalMovement, 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        if (horizontalMovement == 0)
        {
            _ani.SetBool("running", false);
        }
        else
        {
            _ani.SetBool("running", true);
        }
        if (horizontalMovement < -0.1)
        {
            _sr.flipX = true;
        }
        else if (horizontalMovement > 0.1)
        {
            _sr.flipX = false;
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            switch (_ani.GetInteger("attackState"))
            {
                case 0:
                    _ani.SetInteger("attackState", 1);
                    _attackState = 1;
                    break;
                case 1:
                    _ani.SetInteger("attackState", 2);
                    _attackState = 2;
                    break;
                case 2:
                    _ani.SetInteger("attackState", 3);
                    _attackState = 3;
                    break;
            }
        }
    }

    public void AttackEnded()
    {
        _ani.SetInteger("attackState", 0);
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && _ani.GetBool("isGrounded"))
        {
            _rb.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
