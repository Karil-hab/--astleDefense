using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour
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
    	TRdoor.position = new Vector3(-2.63f,9f,65.44f);    	
    }
}
