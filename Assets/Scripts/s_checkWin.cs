using UnityEngine;
using System.Collections;

public class s_checkWin : MonoBehaviour {

	GameObject[] DestroyAtoms;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			DestroyAtoms =  GameObject.FindGameObjectsWithTag ("Atom");
			for(var i = 0 ; i < DestroyAtoms.Length ; i ++) {
				if (DestroyAtoms[i].name == "OxygenAtom") {
					if (DestroyAtoms[i].GetComponent<s_AtomData>().Attached.Count == 2) {
					StartCoroutine(Wait());

					}
				}
			}
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds(5);
		Application.LoadLevel("level2");
	}
}
