using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float power;
    public GameObject Plane;

    private Rigidbody rb; 

    
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    
    void FixedUpdate()
    {
        //setting key presses to bools (true/false)
        bool isS = Input.GetKey(KeyCode.S);
        bool isW = Input.GetKey(KeyCode.W); 
        bool isRight = Input.GetKey(KeyCode.RightArrow);
        bool isLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isForward = Input.GetKey(KeyCode.UpArrow);
        bool isA = Input.GetKey(KeyCode.A);
        bool isD = Input.GetKey(KeyCode.D);

        //setting rotation amount values
        Vector3 rotX = new Vector3(0.0f, 0.0f, -1.0f);
        Vector3 rotY = new Vector3(0.0f, 0.5f, 0.0f);
        Vector3 rotZ = new Vector3(2.0f, 0.0f, 0.0f);

        //
        if (isForward == true)
        {
            rb.AddRelativeForce(Vector3.forward * power * 100);
        }

        if (isW == true)
        {
            Plane.transform.Rotate(rotZ);
        }
        if (isS == true)
        {
            Plane.transform.Rotate(-rotZ);
        }

        if (isRight == true && Plane.transform.rotation.x <= 90)
        {
            //Plane.transform.Rotate(rotX);
            //Plane.transform.Rotate(rotY);
            rb.AddRelativeForce(Vector3.right * power * 100);
        }
        if (isLeft == true && Plane.transform.rotation.x >= -90)
        {
            //Plane.transform.Rotate(-rotX);
            //Plane.transform.Rotate(-rotY);
            rb.AddRelativeForce(Vector3.left * power * 100);
        }

       
        if (isA == true)

        {
            //rb.AddRelativeForce(Vector3.left * power * -100);
            Plane.transform.Rotate(-rotX);
        }
        if (isD == true)
        {
            //rb.AddRelativeForce(Vector3.right * power * -100);
            Plane.transform.Rotate(rotX);
        }

    }
}
