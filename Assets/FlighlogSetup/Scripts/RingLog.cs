using UnityEngine;
using System.Collections;

public class RingLog : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
    if(other.gameObject.name == "NoseCapsule")
		  Debug.Log(gameObject.name);
	}
}
