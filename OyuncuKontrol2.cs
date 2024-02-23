using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol2 : MonoBehaviour
{
    public float jumpForce = 2.0f;
    public float speed = 1.0f;
    private float moveDirection;
    private bool jump;
    private bool grounded = true;
    private bool moving;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private SpriteRenderer _renderer;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (_rigidbody.velocity != Vector2.zero)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        _rigidbody.velocity = new Vector2(speed*moveDirection,_rigidbody.velocity.y);
        if (jump == true)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpForce);
            jump = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (grounded==true &&(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D)))
        {
            if (Input.GetKey(KeyCode.A))
            {
                moveDirection = -1.0f;
                _renderer.flipX = true;
                _animator.SetFloat("speed",speed);
            }
            else if(Input.GetKey(KeyCode.D))
            {
                moveDirection = 1.0f;
                _renderer.flipX = false;
                _animator.SetFloat("speed",speed);
            }
        }
        else if (grounded==true)
        {
            moveDirection = 0.0f;
            _animator.SetFloat("speed",0.0f);
            
        }
        if (grounded == true && Input.GetKey(KeyCode.W) )
        {
            jump = true;
            grounded = false;
            _animator.SetTrigger("jump");
            _animator.SetBool("grounded",false);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zemin")
        {
            grounded = true;
            Debug.Log("Çarptýk");
            _animator.SetBool("grounded", true);
        }
        
    }
}
