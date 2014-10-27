using UnityEngine;
using System.Collections;

public class SaveMovement : MonoBehaviour {

    float time = 0.1f;
    float resetTime = 0.1f;
    PlayerMovment playerMovement;
    Transform obj_player;
    public Sprite path_sprite;
	void Start () {
        obj_player = GameObject.FindGameObjectWithTag("Player").transform;
        playerMovement = obj_player.GetComponent<PlayerMovment>();
	}

	void Update () {
        if (!playerMovement.moveState.Equals(MoveState.ideal))
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                GameObject path = new GameObject("path");
                path.transform.parent = GameObject.FindGameObjectWithTag("PathLevel").transform;
                SpriteRenderer spriteRender = (SpriteRenderer)path.AddComponent(typeof(SpriteRenderer));
                spriteRender.transform.position = gameObject.transform.position;
                spriteRender.sprite = path_sprite;
                DoNotDestroyMe doNotDestroyMe = path.AddComponent<DoNotDestroyMe>();
                time = resetTime;
                
            }

        }

	}
}
