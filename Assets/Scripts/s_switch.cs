using UnityEngine;
using System.Collections;

public class s_switch : MonoBehaviour {

	public GameObject trigger;
	public GameObject Atom;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		 if (collision.gameObject.tag.Equals("Atom")) {
			Debug.Log ("collision");
			if (trigger.name.Equals("Gate"))
			trigger.GetComponent<s_gate> ().sw = !trigger.GetComponent<s_gate> ().sw;
			if (trigger.name.Equals("Platform"))
			trigger.GetComponent<s_move> ().sw = true;
			if (Atom) {
				Atom.GetComponent<s_AtomData>().moveable = true;
			}
			Destroy (this);
		}
	}
}
