using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
	float moveVert;
	float moveHorizon;
    public Animator animator;
	int state = 0;
	bool isAttak = true;

	NavMeshAgent move;
	public GameObject player;
	Transform playerGeolocated;
	float dist;

	Rigidbody m_Rigidbody;

	public float HP  = 9f;
	float DMG = 3f;
	float punch = 2f;
	

    void Start()
    {
    	move = GetComponent<NavMeshAgent>();
    	m_Rigidbody = GetComponent<Rigidbody>();
        playerGeolocated = player.GetComponent<Transform>();
    }

   
    void Update()
    {

    	if(HP <= 0)
    	{
    		
    		transform.localScale -= new Vector3(3 * Time.deltaTime,3 * Time.deltaTime,3 * Time.deltaTime);
    		
    		Destroy(gameObject, 1f);
    	}

    	


    	dist = Vector3.Distance(player.transform.position, transform.position);
    	
    	if (dist<=17f)
      	{
      		FreezePosition();
      		animator.SetInteger("State",1);
      		move.SetDestination(player.transform.position);

	      	if (isAttak && dist<=3f)
		    {
		       	animator.SetInteger("State",Random.Range(2,4));
		       	Invoke("AttakON",1f);
		       	isAttak = false;
		    }
      	} 	
      	else
      	{
      		m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll ;
      		animator.SetInteger("State",0);
      	}
    }

    void AttakON()
    {
    	isAttak = true;
    }

    void FreezePosition()
    {
    	m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY ;
    }

    public void Punch()
    {
    	FindObjectOfType<win>().Win(punch);
    	HP-=2;
    }
    public void FireBoll()
    {
		FindObjectOfType<win>().Win(DMG);
    	HP-=DMG;
    }
    public void DAMege()
    {
    	
    	DMG-=0.5f;
    }
}
