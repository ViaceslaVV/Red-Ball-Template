using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class secret : MonoBehaviour
{
    SpriteShapeRenderer renderer;
    bool visible;
    void Start()
    {
        renderer = GetComponent<SpriteShapeRenderer>();
    }
    void Update()
    {
        if (visible)
        {
            renderer.color = new Color(1, 1, 1, 1f);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        visible = true;
    }
}
