﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player_Network_Setup : NetworkBehaviour {

	[SerializeField] Camera FPSCharacterCam;
	[SerializeField] AudioListener audioListener;

	// Use this for initialization
	void Start () 
	{
		if (isLocalPlayer) 
		{
			GameObject.Find ("Scene Camera").SetActive(false);

			GetComponent<CharacterController>().enabled = true;
			GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;

			FPSCharacterCam.enabled = true;
			audioListener.enabled = true;
		}
	}
	

}
