using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerPrefab : MonoBehaviour
{
    private Function function;
    private Rigidbody2D rb;
    private Animator anim;
    public LayerMask floor;
    public Transform _canJump;
    private float jumpStrenght = 8f;
    private float moveSpeed = 5f;
    private bool lookRight = true;
    private bool canJump;
    void Start()
    {
        function = GameObject.FindGameObjectWithTag("GameController").GetComponent<Function>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        canJump = Physics2D.OverlapCircle(_canJump.position, 0.1f, floor);
        float Horizontal = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(Horizontal));
        movement(Horizontal);
        jumping();
    }
    void movement(float Horizontal){
        if (Horizontal < 0 && lookRight == true)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            lookRight = false;
        }
        if (Horizontal >0 && lookRight == false)
        {
            transform.localScale = new Vector3(1, 1, 1);
            lookRight = true;
        }
        rb.velocity = new Vector2(moveSpeed * Horizontal, rb.velocity.y);
    }
    void jumping(){
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && canJump == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpStrenght);
        }
    }
}
