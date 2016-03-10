using UnityEngine;
using System.Collections;

public class RingLog : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
		Debug.Log(gameObject.name);
	}
}
