using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_0 : MonoBehaviour
{
    [SerializeField] private float upForce;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask ground;
    [SerializeField] private float radius;

    private Rigidbody2D person1;
    private Animator Person1Animator;

    void Start()
    {
        person1 = GetComponent<Rigidbody2D>();  
        Person1Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isGrounded = Physics2D. OverlapCircle(groundCheck.position, radius, ground);
        Person1Animator.SetBool("isGrounded", isGrounded);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
        {
            person1.AddForce(Vector2.up * upForce);
        }
    }
    }
    private void OnDrawGizmos ()
        {  
        Gizmos.DrawWireSphere(groundCheck.position, radius);
        }

    private void OnCollisionEnter2D(Collision2D colliaion)
    {
        if (colliaion.gameObject.CompareTag("Obstacle"))
        {
            GameManager.Instance.ShowGameOverScreen();
            //Person1Animator.SetTrigger("Over");
            Time.timeScale = 0f;
        }
    }
}