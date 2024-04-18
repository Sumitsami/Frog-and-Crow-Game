using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed; 

    private Vector2 mousePos;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 dir = new Vector2(Camera.main.ScreenToWorldPoint(mousePos).x, Camera.main.ScreenToWorldPoint(mousePos).y) - new Vector2(transform.position.x, transform.position.y);
        dir.Normalize();
        rb.AddForce(dir * speed);

        float angle = Mathf.Atan(dir.y / dir.x) * Mathf.Rad2Deg;
        if (dir.x < 0)
            angle += 180;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
       
    }
    public void MousePosition(InputAction.CallbackContext context)
    {
        mousePos = context.ReadValue<Vector2>();
    }
}
