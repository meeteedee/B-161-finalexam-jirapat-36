using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public fields
    private float moveSpeed = 5f;
    private float jumpForce = 10f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        }
        
        //OnTriggerEnter2D(Collider2D);
    }
}
