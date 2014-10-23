using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class s_AtomData : MonoBehaviour {

	public int AtomType;
	public GameObject Attach;
	public List<GameObject> Attached = new List<GameObject>();
	public bool moveable;
	Vector3 dir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (moveable == true) {
			gameObject.rigidbody.isKinematic = false;
		} else {
			gameObject.rigidbody.isKinematic = true;
		}


		if (Attach) {
			float distance = Vector3.Distance (gameObject.transform.position, Attach.transform.position);
						if (distance > 0.20) {
								dir = gameObject.transform.position - Attach.transform.position;
								dir = dir.normalized;
								gameObject.rigidbody.AddForce (dir * -1);
						} else {
								gameObject.rigidbody.velocity = Vector3.zero;
								gameObject.rigidbody.angularVelocity = Vector3.zero;
						}
						Attach.rigidbody.velocity = Vector3.zero;
						Attach.rigidbody.angularVelocity = Vector3.zero;
		}
	}


}
