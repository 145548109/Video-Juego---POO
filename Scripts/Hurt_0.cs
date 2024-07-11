using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_0 : MonoBehaviour
{
    [SerializeField] private float upForce;

    private Rigidbody2D person1;

    void Start()
    {
      person1 = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            person1.AddForce(Vector2.up * upForce);
        }
    }
}



