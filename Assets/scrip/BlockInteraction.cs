using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInteraction : MonoBehaviour
{
    float horizontal;
    float vertical;
    public int speed = 5;

    Rigidbody rb;

    Vector3 CameraPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        CameraPos = Camera.main.transform.forward;
    }

    private void FixedUpdate()
    {
        Vector3 position = rb.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        position.z = position.z + speed * vertical * Time.deltaTime;

        rb.MovePosition(position);
    }
}
