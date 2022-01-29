using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FierBoll : MonoBehaviour
{
    public GameObject bullet;
    Transform TRbulet;
    GameObject clonBullet;
    Rigidbody RBbulet;
    float rand = 1f;
    float Rholl = 5f;
    float Rboll = 1f;
    bool isShootFireBoll=false;
    bool isShootFireHoll=false;
    AudioSource shootSound;
    public AudioSource shootSound2;
    public bool chetiki;

    bool MojnoBoll = false;
    bool MojnoHoll = false;
    // Start is called before the first frame update
    void Start()
    {
        TRbulet = GetComponent<Transform>();
        shootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    	if((Input.GetMouseButtonDown(1) && MojnoBoll) || chetiki)
    	{
    		if(!isShootFireBoll)
    		{
    			FireBoll();
    			shootSound.Play();
    			Invoke("FireBollOn",Rboll);
    		}
    		isShootFireBoll=true;
    	}

    	if((Input.GetKeyDown("f") && MojnoHoll) || chetiki)
    	{
    		if(!isShootFireHoll)
    		{
    			FireHoll();
    			shootSound2.Play();
    			Invoke("FireHollOn",Rholl);
    		}
    		isShootFireHoll=true;
    	}
        
    }
	
	void FireBollOn()
	{
		isShootFireBoll = false;
	}
	
	void FireHollOn()
	{

		isShootFireHoll = false;
	} 

    void FireBoll()
    {
    	clonBullet = Instantiate(bullet,TRbulet.position,TRbulet.rotation);
        RBbulet = clonBullet.GetComponent<Rigidbody>();
        RBbulet.AddForce(TRbulet.forward * 1000f);
        Destroy(clonBullet,1);
    }
    void FireHoll()
    {
    	for(int i=0; i<20; i+=1)
    	{
    		clonBullet = Instantiate(bullet, new Vector3(transform.position.x,transform.position.y+Random.Range(-rand, rand),transform.position.z+Random.Range(-rand, rand)) ,TRbulet.rotation);
        	RBbulet = clonBullet.GetComponent<Rigidbody>();
        	RBbulet.AddForce(TRbulet.forward * 1000f);
        	Destroy(clonBullet,1);
    	}	
    }
    public void MojnoBolls()
    {
    	MojnoBoll = true;
    }
    public void MojnoHolls()
    {
    	MojnoHoll = true;
    }
}
