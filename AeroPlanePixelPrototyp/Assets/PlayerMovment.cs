using UnityEngine;
using System.Collections;
public enum MoveState
{
    up,
    down,
    right,
    left,
    ideal
}
public class PlayerMovment : MonoBehaviour {

    Rigidbody2D rigidbody2D;
    public MoveState moveState;
    public float speed;
    public int Buttonset = 0;

	void Start () {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        moveState = MoveState.ideal;
        Debug.Log(moveState);
        
            
	}
	
	void Update () {

        if (moveState.Equals(MoveState.up))
        {
            rigidbody2D.gravityScale = 0;
            rigidbody2D.mass = 0;
            transform.position += transform.up * speed;
            Debug.Log("upUpdate");
        }
        if (moveState.Equals(MoveState.right))
        {
            rigidbody2D.gravityScale = 0;
            
            transform.position += transform.right * speed;
        }
        if (moveState.Equals(MoveState.down))
        {
            transform.position -= transform.up * speed;
        }
        if (moveState.Equals(MoveState.left))
        {
            rigidbody2D.gravityScale = 0;

            transform.position -= transform.right * speed;
        }
        
	}
    public void directionChange(string movement)
    {
        if (movement == "right")
        {
            moveState = MoveState.right;
            Buttonset++;
            Debug.Log(movement);
        }
        if (movement == "left")
        {
            moveState = MoveState.left;
            Buttonset++;
            Debug.Log(movement);
        }
        if (movement == "up")
        {
            moveState = MoveState.up;
            Buttonset++;
            Debug.Log(movement);
        }
        if (movement == "down")
        {
            moveState = MoveState.down;
            Buttonset++;
            Debug.Log(movement);
        }
    }
}
