using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravityScale = 2f;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;

    private Rigidbody rb;
    private Collider col;

    private bool isGrounded;
    private float gravity;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();

        gravity = Physics.gravity.y * gravityScale;
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        isGrounded = GroundCheck();

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        Vector3 velocity = moveDirection * moveSpeed;

        rb.velocity = new Vector3(velocity.x, rb.velocity.y, velocity.z);
        rb.velocity += Vector3.up * gravity * Time.fixedDeltaTime;
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    bool GroundCheck()
    {
        Bounds bounds = col.bounds;
        Vector3 start = bounds.center;
        start.y = bounds.min.y;
        return Physics.CheckSphere(start, groundCheckDistance, groundLayer);
    }
}