using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpSpeed;
    public float movespeed;
    Rigidbody2D rb;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity += Vector2.up * jumpSpeed;
        }
        var hor = Input.GetAxisRaw("Horizontal");
        rb.velocity -= Vector2.right * hor * Time.deltaTime * movespeed;
         
    }
   

}
