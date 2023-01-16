using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    Vector2 movement;
   public Animator anim;
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        anim.SetFloat("run", movement.x);
        anim.SetFloat("run", movement.y);

        if (movement.x >= 1 || movement.y >= 1)
        {
         
        }
        else 
        {


            //anim.SetFloat("run", 0);
            //anim.SetFloat("run", 0);
        }

        //PlayerMove(moveSpeed);


    }

    //public void PlayerMove(float moveSpeed)
    //{
    //    //movement input
    //    var moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    //    var moveVelocity = moveInput.normalized * moveSpeed;
    //    Move(moveVelocity);

    //    //Animation value
    //    float animationSpeedPercent = ((moveSpeed) * 2.5f) * moveInput.magnitude;
    //    anim.SetFloat("run", animationSpeedPercent);

    //}

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    //public void Move(Vector3 velocity)
    //{
    //    this.velocity = velocity;


    //}

}
