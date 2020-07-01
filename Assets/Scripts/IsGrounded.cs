using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    private GameObject _player;
    private Animator _animator;
    void Start()
    {
        _player = gameObject.transform.parent.gameObject;
        _animator = _player.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            _animator.SetBool("isGrounded", true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            _animator.SetBool("isGrounded", false);
        }
    }
}
