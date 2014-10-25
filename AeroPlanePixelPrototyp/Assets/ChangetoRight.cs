using UnityEngine;
using System.Collections;

public class ChangetoRight : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject gO = GameObject.Find("left");
            gO.name = "right";
        }
    }
}
