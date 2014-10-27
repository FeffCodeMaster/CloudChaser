using UnityEngine;
using System.Collections;

public class movementbuttons : MonoBehaviour
{

    PlayerMovment playerMovement;
    Transform obj_PlayerMovement;
    GUITexture gTexture;
    public Texture right, left, up, down;

    void Start()
    {
        obj_PlayerMovement = GameObject.FindGameObjectWithTag("Player").transform;
        playerMovement = obj_PlayerMovement.GetComponent<PlayerMovment>();
        gTexture = gameObject.GetComponent<GUITexture>();
    }

    // Update is called once per frame
    void Update()
    {
        changePictures();
        changeButtonSet();
        if (Input.GetMouseButtonDown(0))
        {

            if (gTexture.GetScreenRect().Contains(Input.mousePosition))
            {
                playerMovement.directionChange(gameObject.name);
            }
        }
    }
    private void changePictures()
    {
        if (gameObject.name == "right")
            gTexture.texture = right;
        if (gameObject.name == "left")
            gTexture.texture = left;
        if (gameObject.name == "up")
            gTexture.texture = up;
        if (gameObject.name == "down")
            gTexture.texture = down;

    }
    private void changeButtonSet()
    {
        GameObject button1 = GameObject.FindGameObjectWithTag("button1");
        GameObject button2 = GameObject.FindGameObjectWithTag("button2");
        GameObject button3 = GameObject.FindGameObjectWithTag("button3");
        string rightOrLeft;

        if (GameObject.Find("right"))
            rightOrLeft = "right";
        else
            rightOrLeft = "left";
        Debug.Log(rightOrLeft);
        if (playerMovement.Buttonset == 0)
        {
            button1.name = rightOrLeft;
            button2.name = "up";
            button3.name = "down";
        }
        if (playerMovement.Buttonset == 1)
        {
            button1.name = "down";
            button2.name = rightOrLeft;
            button3.name = "up";
        }
        if (playerMovement.Buttonset == 2)
        {
            button1.name = "up";
            button2.name = "down";
            button3.name = rightOrLeft;
         
        }
        if (playerMovement.Buttonset <= 3)
        {
            playerMovement.Buttonset = 0;
        }
        Debug.Log(playerMovement.Buttonset);
    }
    
}
