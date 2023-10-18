using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class dashed : MonoBehaviour
{
    public float speed;
    public float speedRotation;
    private Vector2 movementValue;
    private float lookValue;
    public GameObject prefab;
    public GameObject shootPoint;
    public float dashMulti;
    // Start is called before the first frame update

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * speedRotation;
    }

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
    }

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
}
