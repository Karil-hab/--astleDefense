using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
	float scor = 0;
	public AudioSource miloNT;
    public GameObject Winers;
    Transform TRhren;
    GameObject hren;
    AudioSource shootSound;
    public GameObject CHERTILO;
    // Start is called before the first frame update
    void Start()
    {
        shootSound = GetComponent<AudioSource>();
        TRhren= GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Win(float arg)
    {
    	scor=scor+arg;

        if(GameObject.Find("enemy (2)") == null)
        {
            miloNT.Stop();
            shootSound.Play();
            for(int i=0; i<80; i+=1)
            {
                hren = Instantiate(Winers, new Vector3(transform.position.x+Random.Range(-90, 80),transform.position.y,transform.position.z+Random.Range(-100, 53)) ,TRhren.rotation);
            
                Destroy(hren,40);
            }   
        }
    }
}

