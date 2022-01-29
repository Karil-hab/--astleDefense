using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest2 : MonoBehaviour
{
	AudioSource shootSound;
	public GameObject talk;
	public AudioSource milo;
	public AudioSource miloNT;
    // Start is called before the first frame update
    void Start()
    {
        shootSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay (Collider hit)
    {
    	if (hit.gameObject.tag == "Player")
	    {
	    	if (Input.GetButton("Jump"))
		    {
		    	FindObjectOfType<FierBoll>().MojnoBolls();
		    	FindObjectOfType<door>().Open();
		    	FindObjectOfType<door2>().Open();


		    	talk.SetActive(true);

				FindObjectOfType<zaibl>().Find();
		       	shootSound.Play();
		       	transform.localScale -= new Vector3(3 * Time.deltaTime,3 * Time.deltaTime,3 * Time.deltaTime);

    			Destroy(gameObject, 1f);
		    }
	    }
    } 
}
