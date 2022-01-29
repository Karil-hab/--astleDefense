using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class canvas : MonoBehaviour
{
	public TextMeshProUGUI Da;
	int HP = 15;
	     // Start is called before the first frame update
    void Start()
    {
        //Da = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Da.text = ""+HP+"";
    }

    public void Heal(int HPP)
    {
    	HP=HPP;
    }
}
