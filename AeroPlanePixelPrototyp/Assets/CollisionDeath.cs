using UnityEngine;
using System.Collections;

public class CollisionDeath : MonoBehaviour {

    string levelName;
	void Start () {
        levelName = Application.loadedLevelName;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Application.LoadLevel(levelName);
        }
    }
}
