using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
	AudioSource shootSound;
    // Start is called before the first frame update
    void Start()
    {
        shootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision obg)
    {
    	if(obg.gameObject.tag == "enemy")
		{
			FindObjectOfType<enemy>().FireBoll();
			shootSound.Play();
		}
		if(obg.gameObject.tag == "Untagged")
		{
			shootSound.Play();
		} 
    }
}
