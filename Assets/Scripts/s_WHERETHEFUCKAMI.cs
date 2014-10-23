using UnityEngine;
using System.Collections;

public class s_WHERETHEFUCKAMI : MonoBehaviour {

	public GameObject tp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= -5) {
			gameObject.transform.position = tp.transform.position;
				}
	}
}
