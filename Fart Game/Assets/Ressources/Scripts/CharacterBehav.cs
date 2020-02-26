using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehav : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    private bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            Jump();
        }
        if (Input.GetKeyDown("a") && isGrounded)
        {
            rb.velocity += new Vector2(-vitesse,0);
        }
        if (Input.GetKeyDown("d") && isGrounded)
        {
            rb.velocity += new Vector2(vitesse,0);
        }

        
    }

    void Jump(){
        rb.velocity += new Vector2(0, maxJump);
    }

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col) {
        if(col.gameObject.CompareTag("Ground")){
            isGrounded = false;
        }
    }
}
