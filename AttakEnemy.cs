using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttakEnemy : MonoBehaviour
{
	bool isAttak = true;
	float dist;
	public GameObject player;
	AudioSource shootSound;
    // Start is called before the first frame update
    void Start()
    {
        shootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		dist = Vector3.Distance(player.transform.position, transform.position);        
    }

    private void OnTriggerStay (Collider hit) 
    { 
	    if(hit.gameObject.tag == "Player")
	    {	    	
		    if (isAttak && dist<=3f)
		    {	
		    	shootSound.Play();
		       	FindObjectOfType<dude>().PunchEnemy();
		       	Invoke("AttakON",1f);
	       		isAttak = false;
		    }
	    }
    }

    void AttakON()
    {
    	isAttak = true;
    }

}
