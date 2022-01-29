using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotMenu : MonoBehaviour
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
       	transform.Rotate(0.0f, 2.0f, 0.0f);
    }
}
