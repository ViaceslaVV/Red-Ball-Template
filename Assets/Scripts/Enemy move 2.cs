using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove2 : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;

    private Vector2 startingPosition;

    private bool movingUp = true;
    


    void Start()
    {

        startingPosition = transform.position;
    }

    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {

        if (movingUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);


            if (Vector2.Distance(startingPosition, transform.position) >= moveDistance)
            {
                movingUp = false;
            }
        }

        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);


            if (Vector2.Distance(startingPosition, transform.position) <= 0.1f)
            {
                movingUp = true;
            }
        }


    }
}
