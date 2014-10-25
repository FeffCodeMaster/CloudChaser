using UnityEngine;
using System.Collections;

public class LevelMusic : MonoBehaviour {
		PlayerMovment playermovment;
		Transform obj_playermovement;
		AudioSource audioSource;
		public AudioClip audioClip;
		int musicStared = 0;
	void Start () {
				audioSource = gameObject.GetComponent<AudioSource> ();
				obj_playermovement = GameObject.FindGameObjectWithTag ("Player").transform;
				playermovment = obj_playermovement.GetComponent<PlayerMovment> ();	
				audioSource.clip = audioClip;
	}
	
	// Update is called once per frame
	void Update () {
				if (musicStared == 0 && !playermovment.moveState.Equals (MoveState.ideal)) {
						audioSource.Play ();
						musicStared++;
				}
	}
}
