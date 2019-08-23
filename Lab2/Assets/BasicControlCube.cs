using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//camera is from top (Y-axis)

public class BasicControlCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
       if ( Input.GetKey(KeyCode.UpArrow) ) {
            //going up will change z 
            this.transform.localPosition += new Vector3(0.0f, 0.0f, 1.0f);


       }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.localPosition += new Vector3(0.0f, 0.0f, -1.0f);


        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.localPosition += new Vector3(-1.0f, 0.0f, 0.0f);


        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //going right will change x 
            this.transform.localPosition += new Vector3(1.0f, 0.0f, 0.0f);


        }
    }
}
