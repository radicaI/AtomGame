using UnityEngine;
using System.Collections;

public class s_checkWin3 : MonoBehaviour {

	GameObject[] DestroyAtoms;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		DestroyAtoms =  GameObject.FindGameObjectsWithTag ("Atom");
		for(var i = 0 ; i < DestroyAtoms.Length ; i ++) {
			if (DestroyAtoms[i].name == "CarbonAtom") {
				if (DestroyAtoms[i].GetComponent<s_AtomData>().Attached.Count == 4) {
					StartCoroutine(Wait());
					
				}
			}
		}
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds(5);
		Application.LoadLevel("menu");
	}
}
