using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    CharacterController cc;
    float multiplier = 1;
    public float speed;
    public float gravity;
    Vector3 inputMove;
    public float jumpHeight;
    Animator anim;
    Vector3 lookLeft = new Vector3(-1, 1, 1);
    Vector3 lookRight = Vector3.one;

    void Start ()
    {

        cc = GetComponent<CharacterController> ();
        anim = GetComponent<Animator> ();

    }

    void Update ()
    {

        multiplier = 1f;
        anim.SetFloat ("Speed", Mathf.Abs (inputMove.x));
        
        if(Input.GetAxisRaw("Horizontal") >= 0.01f)
        {

            transform.localScale = lookRight;

        }
        if(Input.GetAxisRaw("Horizontal") <= -0.01f)
        {

            transform.localScale = lookLeft;

        }

        if (cc.isGrounded)
        {
            inputMove.y = 0;
            multiplier = 1;

            if (anim.GetBool ("IsJumping"))
            {

                anim.SetBool ("IsJumping", false);

            }

            if (Input.GetButtonDown ("Jump"))
            {

                //anim.SetBool ("IsJumping", true);
                inputMove.y = jumpHeight;

            }

        }

        if (!cc.isGrounded)
        {

            anim.SetBool ("IsJumping", true);

        }

        inputMove.x = Input.GetAxisRaw ("Horizontal") * speed * multiplier;

        inputMove.y -= gravity * Time.deltaTime;

        cc.Move (inputMove * Time.deltaTime);

    }

}
