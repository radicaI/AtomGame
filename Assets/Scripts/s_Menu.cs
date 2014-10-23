using UnityEngine;
using System.Collections;

public class s_Menu : MonoBehaviour {

	public GameObject[] SpawnAtoms;
	GameObject last;
	int count;
	GameObject[] DestroyAtoms;

	// Use this for initialization
	void Start () {
		StartCoroutine("MenuGraphic");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Atom Game");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Start")) {
			Application.LoadLevel("level1");
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Exit")) {
			Application.Quit();
		}
	}

	IEnumerator MenuGraphic() {
		while (true) {
			yield return new WaitForSeconds (1);
			last = (GameObject) Instantiate (SpawnAtoms [Random.Range(0, 4)], new Vector3 (Random.Range (-7.7f, 7.7f), 17, 0), Random.rotation);
			last.transform.localScale = new Vector3(2, 2, 2);
			count++;
			if (count == 60) {
				DestroyAtoms =  GameObject.FindGameObjectsWithTag ("Atom");
				for(var i = 0 ; i < DestroyAtoms.Length ; i ++) {
					Destroy (DestroyAtoms[i]);
					count = 0;
				}
			}
				}
	}
}
