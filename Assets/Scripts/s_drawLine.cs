using UnityEngine;
using System.Collections;



public class s_drawLine : MonoBehaviour {
	Vector3 lineStart;
	Vector3 lineEnd;
	float distance_to_screen;
	int stage;
	GameObject AtomLineObject;

	public GameObject AtomLine;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetMouseButtonDown (1))&&(stage == 0)) {
			distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
			lineStart = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));
			stage = 1;
			Debug.Log(lineStart);
		} else if ((Input.GetMouseButtonDown (1))&&(stage == 1)) {
			distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
			lineEnd = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen ));

			AtomLineObject = (GameObject) Instantiate(AtomLine);

			LineRenderer lineRenderer = AtomLineObject.GetComponent<LineRenderer>();

			lineRenderer.SetPosition(0, new Vector3(lineStart.x, 2.616508f, lineStart.z));
			lineRenderer.SetPosition(1, new Vector3(lineEnd.x, 2.616508f, lineEnd.z));

			stage = 0;
			Debug.Log(lineEnd);
		}

	
	}
}
