using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisManager : MonoBehaviour
{
    //float vertical;
    //float horizontal;
    // bool downButton;
    float value;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        //downButton = Input.GetMouseButton(0); //left mouse button
        //downButton = Input.GetMouseButton(1); //right mouse button
        //downButton = Input.GetMouseButton(2); //center mouse button

        value = Input.GetAxis("Mouse X");   //x axis movement

        if (value != 0)
            print("X Axis value is " + value);

        value = Input.GetAxis("Mouse Y");   //y axis movement

        if (value != 0)
            print("Y Axis value is " + value);

        //vertical = Input.GetAxis("Vertical");
        //if (vertical != 0)
        //    print("Value of Vertical " + vertical);
        //horizontal = Input.GetAxis("Horizontal");
        //if (horizontal != 0)
        //    print("value of Horizontal " + horizontal);
    }
}
