using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isGrounded = false;
    [SerializeField] private float speed = 5.0f;
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 5;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    protected virtual void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = transform.right * horizontal + transform.forward * vertical;
        float sqrLength = dir.sqrMagnitude;
        if (sqrLength > 1)
        {
            dir.Normalize();
        }
        rb.MovePosition(transform.position + dir * speed * Time.deltaTime);
        if (Input.GetButton("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
        }
    }
}
