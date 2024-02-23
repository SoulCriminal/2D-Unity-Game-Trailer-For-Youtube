using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D _rigidbody2d;
    private Animator _animator;
    private Vector3 charPos;
    [SerializeField] private GameObject _camera;
    private SpriteRenderer _renderer;

   

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        charPos = transform.position;
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //_rigidbody2d.velocity = new Vector2(speed,0f);
        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal")*speed*Time.deltaTime),charPos.y);
        transform.position = charPos;

        if (Input.GetAxis("Horizontal")==0.0f)
        {
            _animator.SetFloat("speed",0.0f);
        }
        else
        {
            _animator.SetFloat("speed", speed);
        }
        if (Input.GetAxis("Horizontal")>0.01f)
        {
            _renderer.flipX = false;
        }
        else if (Input.GetAxis("Horizontal")<-0.01)
        {
            _renderer.flipX = true;
        }
    }

    private void LateUpdate()
    {
        _camera.transform.position = new Vector3(charPos.x,charPos.y,charPos.z-1.0f);
    }
    
}
