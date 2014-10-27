using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    GUIText guiText;
    float time;
    PlayerMovment playerMovement;
    Transform obj_player;
	void Start () {
        guiText = gameObject.GetComponent<GUIText>();
        obj_player = GameObject.FindGameObjectWithTag("Player").transform;
        playerMovement = obj_player.GetComponent<PlayerMovment>();

	}
	
	// Update is called once per frame
	void Update () {
        if(!playerMovement.moveState.Equals(MoveState.ideal))
        time += Time.deltaTime;

        guiText.text = time.ToString("0.00");
	}
}
