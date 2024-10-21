using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpSpeed =10;
    public float acceleration = 5;
    
    public float maxspeed = 10;
    Rigidbody2D rb;
    public bool isGrounded;
    public GameObject playerPiece;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity += Vector2.up * jumpSpeed;
        }
        if(Mathf.Abs(rb.velocity.x)< maxspeed)
        {
            float hor = Input.GetAxisRaw("Horizontal");
            rb.velocity += Vector2.right * hor * Time.deltaTime * acceleration ;
        }
        
         
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
        if (other.gameObject.CompareTag("Enemy"))
        {
            for (int i = 0; i < 10; i++)
            {
                var pos = transform.position + Random.insideUnitSphere;
                Instantiate(playerPiece,pos, transform.rotation);
            }
            gameObject.SetActive(false);

            GameManager.instance.Die();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.Die();
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }


}
