using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// switch control between AccelerationControl & Control by pressing s key
public class SwitchControlMode : MonoBehaviour
{

    //public variables are used to switch between script

    //2nd way
    public BasicControlCube basicControlCube;
    public AccelerationControlCube accelerationControlCube;


    //public variables are used to switch between scripts

    private bool accelerateMode;

    // Start is called before the first frame update
    void Start()
    {

        //2nd way: use component pattern
        basicControlCube = GetComponent<BasicControlCube> ();
        accelerationControlCube = GetComponent<AccelerationControlCube>();



        SetBasicControlCube();

    }

    private void SetBasicControlCube()
    {
        basicControlCube.enabled = true;
        accelerationControlCube.enabled = false;
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }


    private void SetAccelerationControlCube()
    {
        basicControlCube.enabled = false;
        accelerationControlCube.enabled = true;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            accelerateMode = !accelerateMode;

            changeMode();
        }
    }

    private void changeMode()
    {
        if (accelerateMode) {
            SetAccelerationControlCube();
        }
        else {
            SetBasicControlCube();
        }
    }
}
