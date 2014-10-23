using UnityEngine;
using System.Collections;

public class s_hideself : MonoBehaviour {

	GameObject[] HideUi;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			gameObject.guiTexture.enabled = !gameObject.guiTexture.enabled;
			HideUi =  GameObject.FindGameObjectsWithTag ("UI");
			for(var i = 0 ; i < HideUi.Length ; i ++) {
				if (gameObject.guiTexture.enabled == false) {
				Destroy(HideUi[i]);
					Destroy(gameObject);
				}
			}
		}
	}
}
