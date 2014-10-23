using UnityEngine;
using System.Collections;

public class ClickDrag : MonoBehaviour {

	int follow = 0;
	float distance_to_screen;
	Vector3 pos_move;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (follow == 1) {
			transform.rotation = new Quaternion(45, 0, 0, 90);
			distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
			pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));
			transform.position = new Vector3( pos_move.x, 0.58f, pos_move.z );
			rigidbody.velocity = Vector3.zero;
			rigidbody.angularVelocity = Vector3.zero;

		}
	}

	void OnMouseOver() {


		if ((Input.GetMouseButtonDown (0)) && (follow == 0)) {
			Debug.Log ("Following.");
			follow = 1;
		} else if ((Input.GetMouseButtonDown (0)) && (follow == 1)) {
			Debug.Log ("Unfollowing.");
			follow = 0;
		}

	}

	void OnMouseExit() {
	}


}
