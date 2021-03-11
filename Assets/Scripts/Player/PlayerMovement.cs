using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    Vector2 dir;
    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + dir * speed * Time.fixedDeltaTime);
        SetParam();
    }

    void SetParam()
    {
        anim.speed = 3.5f;
        if (dir.x > 0)
        {
            anim.SetInteger("dir", 2);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (dir.x < 0)
        {
            anim.SetInteger("dir", 2);
            GetComponent<SpriteRenderer>().flipX = false;

        }
        else if (dir.y < 0)
            anim.SetInteger("dir", 1);
        else if (dir.y > 0)
            anim.SetInteger("dir", 3);
        else if (dir.x == 0 && dir.y == 0)
        {
            anim.speed = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
