using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationControlCube : MonoBehaviour
{
    //private means can only change within script
    //public means can change outside script (in the editor) 

    private float accelerateX = 0;
    private float accelerateZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //going up will change z 
            accelerateZ+= 0.1f;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            accelerateZ -= 0.1f; 


        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            accelerateX -= 0.1f; 


        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //going right will change x 
            accelerateX += 0.1f; 


        }

        this.transform.localPosition = new Vector3(accelerateX, 0, accelerateZ);

    }
}
