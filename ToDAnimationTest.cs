using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///sprite反转
///</summary>
public class ToDAnimationTest : MonoBehaviour 
{
    private Animator ani;
    private float HorizontalInput;
    private Vector3 moveDirection = new Vector3(0,0,0);
    private enum CharacterDirection { right,left}
    private CharacterDirection dir;
    private SpriteRenderer render;

    public float speed;

    private void Start()
    {
        ani = this.GetComponent<Animator>();
        dir = CharacterDirection.right;
        render = this.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        moveDirection.x = HorizontalInput;
        ani.SetFloat("Input", Mathf.Abs(HorizontalInput));
        CharacterMove();
    }

    private void CharacterMove()
    {
        this.transform.Translate(moveDirection * Time.deltaTime * speed);
        if (dir==CharacterDirection.right&&HorizontalInput<0)
        {
            render.flipX = true;
            dir = CharacterDirection.left;
        }
        if (dir == CharacterDirection.left && HorizontalInput > 0)
        {
            render.flipX = false;
            dir = CharacterDirection.right;
        }
    }

}
