using UnityEngine;
using System.Collections;

public class s_gate : MonoBehaviour {

	public bool sw = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (sw == true) {
			Destroy(gameObject);
		}
	}


}
