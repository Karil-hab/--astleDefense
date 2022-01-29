using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotDude : MonoBehaviour
{

	float xRotate;
    float yRotate;
    float sens = 3f;
    //bool E
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	//ПОВОРОТ
        
        

        if(Input.GetKey("q"))
        {
        	xRotate = xRotate - Input.GetAxis("Mouse Y") * sens;
        	xRotate = Mathf.Clamp(xRotate, -45, 45);
        	transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        }
        else
        {
        	yRotate = yRotate + Input.GetAxis("Mouse X") * sens;      
        	transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        	FindObjectOfType<dude>().Poluchatel(yRotate);
        }

        //РЕЙКАСТ

        /*Debug.DrawRay(transform.position,transform.forward*4f, Color.green);
        RaycastHit hit;*/
        
    }
}
