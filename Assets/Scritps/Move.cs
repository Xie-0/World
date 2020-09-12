//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes m_axes = RotationAxes.MouseXAndY;
    public float m_minimumY = -45f;
    public float m_maximumY = 45f;

    public float m_sensitivityX = 10f;
    public float m_sensitivityY = 10f;


    public float speed = 3;
    //public float turnSpeed = 60;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HelloUnity");
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Screen.lockCursor = true;

        float h = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float v = Input.GetAxis("Jump");
        transform.Translate(new Vector3(h, v, z) * Time.deltaTime * speed);
        //if(h > 0)
        //{
        //    transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
        //}
        //if (h < 0)
        //{
        //    transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed);
        //}

        if (m_axes == RotationAxes.MouseXAndY)
        {
            float m_rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * m_sensitivityX;
            transform.localEulerAngles = new Vector3(0, m_rotationX, 0);
        }
        else if (m_axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * m_sensitivityX, 0);
        }

        if(this.transform.position.y < -50)
        {
            this.transform.position = new Vector3(0, 2, 0);
        }
    }

    //void FixedUpdate()
    //{
    //    this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    //}
}
