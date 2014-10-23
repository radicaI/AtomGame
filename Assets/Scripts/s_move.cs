using UnityEngine;
using System.Collections;

public class s_move : MonoBehaviour {

	public Vector3 dir;
	public float distance;
	public float speed;
	float count;
	public bool sw;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (sw) {
			StartCoroutine ("moveSelf");
			sw = false;
		}
	}

	IEnumerator moveSelf() {
		while (true) {
			if (count == distance) {
				count = 0;
				dir = new Vector3 (-dir.x, -dir.y, -dir.z);
				yield return new WaitForSeconds (2);
			} else { 
				count++;
				gameObject.transform.position = new Vector3 (gameObject.transform.position.x + dir.x,
			                                             	gameObject.transform.position.y + dir.y,
			                                             	gameObject.transform.position.z + dir.z);
				yield return new WaitForSeconds (speed);
			}
		}
	}
}
