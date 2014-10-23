using UnityEngine;
using System.Collections;

public class s_DrawUI : MonoBehaviour {

	public Texture2D[] Icons;
	public GameObject[] Atoms;
	bool draw = false;
	string hover;
	GUIContent Text1 = new GUIContent("Gold");
	GUIContent Text2 = new GUIContent("Ammonia\n NH₃ \n Ammonia, or azane, is a compound of nitrogen and hydrogen. \n It is a colourless gas with a characteristic pungent smell. \n Ammonia contributes significantly to the nutritional needs of terrestrial organisms \n by serving as a precursor to food and fertilizers.\n Ammonia, either directly or indirectly, is also a building-block for \n the synthesis of many pharmaceuticals and is used in many commercial cleaning products. \n Although in wide use, ammonia is both caustic and hazardous.");

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI() {
		if (draw) {
			if (GUI.Button (new Rect (10, 10, 200, 200), new GUIContent (Icons [0], "Button 1"))) {
				Instantiate(Atoms[0], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
				Instantiate(Atoms[0], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
				Instantiate(Atoms[3], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
				Instantiate(Atoms[3], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
				Instantiate(Atoms[3], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
			}

			if (GUI.Button (new Rect (10, 220, 200, 200), new GUIContent (Icons [1], "Button 2"))) {
				Instantiate(Atoms[2], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
				Instantiate(Atoms[1], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
				Instantiate(Atoms[1], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
				Instantiate(Atoms[1], new Vector3(-1.018327f, 0.58f, 1.790525f), Quaternion.identity);
			}
		}

		hover = GUI.tooltip;
		
		if(hover=="Button 1")
			GUI.Box (new Rect (Screen.width - 410,10,400,Screen.height - 20), Text1);

		if(hover=="Button 2")
			GUI.Box (new Rect (Screen.width - 410,10,400,Screen.height - 20), Text2);
		
		
	}
	
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift)) {
			draw = !draw;
		}
	}
}
