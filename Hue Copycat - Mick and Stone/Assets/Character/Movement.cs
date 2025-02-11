using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump;
    private bool Grounded;
    private bool jumping;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float movespeed = 3.0f;
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * movespeed;
        }
        if (Grounded && Input.GetKey(KeyCode.Space) && jumping == true)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump), ForceMode2D.Impulse);
            Grounded = false;
        } 

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Tilemap")
        {
            Debug.Log("should be able to jump");
            Grounded = true;
            jumping = true;
        }
        else
        { 
            Grounded = false;
            jumping = false;  
        }
       
    }
}
