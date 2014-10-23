using UnityEngine;
using System.Collections;

public class s_AttractAtom : MonoBehaviour {

	float distance_to_screen;
	Vector3 pos_move;
	int layerMask = 1 << 8;
	RaycastHit hit;
	RaycastHit hit1;
	RaycastHit hit2;
	int stage = 0;
	Vector3 dir;
	int mv = 0;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Ray ray = camera.ScreenPointToRay(Input.mousePosition);

		if (Input.GetMouseButtonDown(1)) {

			if ((Physics.Raycast(ray, out hit, 1000, layerMask)))
				if (stage == 0) {
					stage = 1;
					hit1 = hit;
				} else {
					stage = 0;
					hit2 = hit;
				if (hit1.Equals(hit2)) {
				} else {
				hit2.rigidbody.velocity = Vector3.zero;
				hit2.rigidbody.angularVelocity = Vector3.zero;
				hit1.transform.gameObject.GetComponent<s_AtomData>().Attach = hit2.transform.gameObject;
				hit2.transform.gameObject.GetComponent<s_AtomData>().Attached.Add(hit1.transform.gameObject);
				}
				}
		}


		
	}
}

