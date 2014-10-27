using UnityEngine;
using System.Collections;

public class DoNotDestroyMe : MonoBehaviour {

	
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
	}
	void Update () {
	
	}
}
