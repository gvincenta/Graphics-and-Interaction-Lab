using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisLinear : MonoBehaviour
{

    public float speed = 1;
    public float maxDistance = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.localPosition.z > maxDistance ) {
            speed  = Mathf.Abs(speed) * (-1); 
        }
        else if (this.transform.localPosition.z < 0)
        {
            speed = Mathf.Abs(speed);
        }
   
            this.transform.localPosition += new Vector3(0.0f, 0.0f, 1.0f * speed);

        


    }
}
