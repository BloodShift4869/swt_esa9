using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody rb;
    private Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pos = rb.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Up and down
        if (Input.GetKey(KeyCode.W)) pos.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S)) pos.Translate(Vector3.back * speed * Time.deltaTime);
        // Left and right
        if (Input.GetKey(KeyCode.A)) pos.Translate(Vector3.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D)) pos.Translate(Vector3.right * speed * Time.deltaTime);

    }
}
