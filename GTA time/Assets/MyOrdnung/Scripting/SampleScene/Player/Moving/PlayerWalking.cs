using UnityEngine;

public class PlayerWalking : MonoBehaviour
{
    public float walkspeed = 5f;
    public Rigidbody2D rb;
    float horizontal;
    float vertical;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(horizontal, vertical).normalized;
        rb.MovePosition(rb.position + movement * walkspeed * Time.fixedDeltaTime);
    }
}
