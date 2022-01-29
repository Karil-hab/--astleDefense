using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scens : MonoBehaviour
{
	 AudioSource shootSound;
	 void Start()
	 {
	 	shootSound = GetComponent<AudioSource>();
	 }
   public void NextLevel(int _sceneNum)
   {
   		shootSound.Play();
   		SceneManager.LoadScene(_sceneNum);
   }
}
