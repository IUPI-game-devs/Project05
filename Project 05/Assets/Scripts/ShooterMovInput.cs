using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShooterMovInput : MonoBehaviour
{
    public float speed;
    public float speedRotation;
    private Vector2 movementValue;
    private float lookValue;
    public GameObject prefab;
    public GameObject shootPoint;
    public float dashMulti;
    public float jumpValue;

    private bool isGrounded;
    private int jumpsLeft = 2; 


    // Start is called before the first frame update
    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Moving
    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    // Looking
    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * speedRotation;
    }

    // Shooting
    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
    }
    // Dash
    public void OnDash()
    {
        movementValue = movementValue * dashMulti;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            movementValue.x * Time.deltaTime,
            0,
            movementValue.y * Time.deltaTime);
        transform.Rotate(0, lookValue * Time.deltaTime, 0);
    }

// Jumping
    public void OnJump(InputValue value)
    {
        if (isGrounded || jumpsLeft > 0)
        {
            if (value.isPressed)
            {
                // Reset vertical velocity before jumping
                GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, 0f, GetComponent<Rigidbody>().velocity.z);
                
                // Perform the jump
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpValue, ForceMode.Impulse);

                // Reduce available jumps if double jumping
                if (!isGrounded)
                {
                    jumpsLeft--;
                }
            }
        }
    }

// Can detect ground
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpsLeft = 1; // Reset available jumps when grounded
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
