using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;     // ���E��?���x
    public float jumpForce = 8f;     // ��?�͓x

    private Rigidbody2D rb;          // ����?��
    private bool isGrounded = false; // ����⋍ݒn��

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ���E��?
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        // ��?�i��i?�C�K?�ݒn��j
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    // ���f���ۗ��ݒn��
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y > 0.5f)
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
