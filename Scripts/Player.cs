using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    private float LookHorizontal = 0;
    private float LookVertical = 0;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            speed = 10f;
        }
        if (Input.GetKeyUp(KeyCode.CapsLock))
        {
            speed = 5f;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 2.5f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
        }
        LookHorizontal += Input.GetAxis("Mouse X");
        LookVertical += Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(-LookVertical, LookHorizontal, 0f);
    }
}
