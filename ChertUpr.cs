using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChertUpr : MonoBehaviour
{
	public GameObject chert;
	public GameObject tablichka;
	float Y ;
    // Start is called before the first frame update
    void Start()
    {
		float Y = -1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,Y*Time.deltaTime,0,Space.World);
        if(transform.position.y>=0.3f)
        {
        	Y=1;
        }   
    }
}
