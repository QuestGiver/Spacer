using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody myRig;
    public float mouseSensX = 3;
    [SerializeField]
    private float XconstraintPos = 7.5f;
    [SerializeField]
    private float XconstraintNeg = -7.5f;
    [SerializeField]
    private float speed = 50;
    [SerializeField]
    public float GetSpeed
    {
        get
        {
            return speed;
        }
    }

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Direction()
    {
        float temp = 0;

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -7.5f)
            {
                temp -= speed;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 7.5f)
            {
                temp += speed;
            }
        }

        transform.Translate(new Vector3(temp, 0, 0) * Time.deltaTime, Space.World);
        temp = 0;

    }

    void MouseLook()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensX);//Do not multiply by time.deltatime as mouse input is frame independant

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0,transform.position.x, 0);
        Direction();
        MouseLook();


    }
}
