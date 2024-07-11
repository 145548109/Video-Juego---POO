using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRepeat : MonoBehaviour
{
    private float spriteWidth;

    void Start()
    {
        BoxCollider2D groundCollider = GetComponent<BoxCollider2D>();
        spriteWidth = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -spriteWidth)
        {
            // Mueve el suelo inmediatamente a la nueva posición
            Vector3 newPosition = transform.position;
            newPosition.x += 2f * spriteWidth;
            transform.position = newPosition;
        }
    }
}
