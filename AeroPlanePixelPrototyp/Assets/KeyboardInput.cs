using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {

    PlayerMovment playerMovment;
    Transform obj_playerMovement;
    float beatsPerSecond;
    float resetBeatsPerSecond;
    public float beatsPerMinute;
	void Start () {
        obj_playerMovement = GameObject.FindGameObjectWithTag("Player").transform;
        playerMovment = obj_playerMovement.GetComponent<PlayerMovment>();
        beatsPerSecond = beatsPerMinute / 60.00f;
        beatsPerSecond = (1 / beatsPerSecond) * 4;
        resetBeatsPerSecond = beatsPerSecond;
        
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown("up"))
        //{
        //    playerMovment.directionChange("up");
        //}
        //if (Input.GetKeyDown("down"))
        //{
        //    playerMovment.directionChange("down");
        //}
        //if (Input.GetKeyDown("right"))
        //{
        //    playerMovment.directionChange("right");
        //}
        //if (Input.GetKeyDown("left"))
        //{
        //    playerMovment.directionChange("left");
        //}
        MakeThePlayerGoByitSelf();
	}

    public void MakeThePlayerGoByitSelf()
    {
        
        
        if (beatsPerSecond > 0)
        {
            beatsPerSecond -= Time.deltaTime;
        }
        if (beatsPerSecond <= 0)
        {
            if (playerMovment.moveState.Equals(MoveState.ideal))
            {
                playerMovment.directionChange("right");
                Debug.Log("GoingRight1");
                beatsPerSecond = resetBeatsPerSecond;
            }
            else if (playerMovment.moveState.Equals(MoveState.right))
            {
                playerMovment.directionChange("up");
                Debug.Log("GoingUp");
                beatsPerSecond = resetBeatsPerSecond;
            }
            else if (playerMovment.moveState.Equals(MoveState.up))
            {
                playerMovment.directionChange("right");
                Debug.Log("GoingRight1");
                beatsPerSecond = resetBeatsPerSecond;
            }
            Debug.Log(resetBeatsPerSecond);
        }
    }
}
