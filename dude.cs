using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dude : MonoBehaviour
{
    float moveVert;
	float moveHorizon;
	Rigidbody RBplayer; 
	Transform TRplayer;
	public Animator animator;
	bool isAttak = false;
	AudioSource shootSound;
	public AudioSource punchSound;
	public GameObject talk;
	bool TeperiNet = true;
	
	int HP = 15;
	bool GO = false;

    void Start()
    {
        RBplayer = GetComponent<Rigidbody>();
        shootSound = GetComponent<AudioSource>();
        TRplayer = GetComponent<Transform>();
    }

   
    void Update()
    {
    	if(HP <= 0)
    	{
    		TRplayer.position = new Vector3(0f,0f,0f);
    		talk.SetActive(true);
    		FindObjectOfType<zaibl>().Dead();
    		HP = 15;
    	}
    	FindObjectOfType<canvas>().Heal(HP);
    	if(GO)
    	{
    		moveVert = Input.GetAxis("Vertical");
	    	moveHorizon = Input.GetAxis("Horizontal");	
    	}
	   


    	if (Input.GetMouseButtonDown(0)  && !isAttak)
	    {
	       	animator.SetInteger("State",Random.Range(2,4));
	       	Invoke("AttakON",0.5f);
	       	punchSound.Play();
	       	isAttak = true;
	    }
    	else if (moveVert != 0 || moveHorizon != 0 & GO)
      	{
      		animator.SetInteger("State",1);

      		RBplayer.velocity = transform.forward * moveVert * 10f;
	        RBplayer.AddForce(transform.right * moveHorizon * 500f); 
      	}
      	else
      	{
      		animator.SetInteger("State",0);
      	}
    }

    void AttakON()
    {
    	isAttak = false;
    }

    void OnTriggerStay (Collider hit) 
    { 
	    if(hit.gameObject.tag == "heal")
	    {	    	
		    if (Input.GetButton("Jump"))
		    {
		    	HP+=5;
		    	
		       	Destroy(hit.gameObject);
		       	shootSound.Play();
		    }
	    }
	    if(hit.gameObject.tag == "gig" & TeperiNet)
	    {
	    	talk.SetActive(true);
	    	TeperiNet = false;
	       	FindObjectOfType<zaibl>().Search();
	    }
    }

    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
  	public void PunchEnemy()
  	{
  		HP-=3;
  	}
  	public void hren()
  	{
  		TRplayer = GetComponent<Transform>();
  	}
  	public void GOGO()
  	{
  		GO = true;
  	}
}



