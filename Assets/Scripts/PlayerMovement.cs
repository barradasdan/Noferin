using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    Rigidbody2D rb;
    Vector2 moveDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ImputManagement();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ImputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.linearVelocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }

}
