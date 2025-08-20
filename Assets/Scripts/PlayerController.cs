using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private Vector3 movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        movement = new Vector3(horizontalInput, 0.0f, verticalInput);
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * speed);
    }
}
