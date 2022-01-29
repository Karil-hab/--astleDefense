using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
	Transform TRdoor;
	
    // Start is called before the first frame update
    void Start()
    {

        TRdoor = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



   	public void Open()
    {
    	TRdoor.position = new Vector3(-0.87f,9f,58.61f);    	
    }
}
