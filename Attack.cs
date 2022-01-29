using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
	bool isAttak = false;
	int DMG = 2;
	AudioSource shootSound;

	void Start()
	{
		
	}

   	
   	private void OnTriggerStay (Collider hit) 
    { 
	    if(hit.gameObject.tag == "enemy")
	    {	    	
		    if (Input.GetMouseButtonDown(0) && !isAttak)
		    {	
		    	//hit.gameObject.GetComponent<enemy>().Punch();
		    	
		       	FindObjectOfType<enemy>().Punch();
		       	
		       	Invoke("AttakON",0.5f);
	       		isAttak = true;
		    }
	    }
    }

    void AttakON()
    {
    	isAttak = false;
    }
}
