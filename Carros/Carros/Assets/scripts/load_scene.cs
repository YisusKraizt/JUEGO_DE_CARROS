using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class load_scene : MonoBehaviour {

	public string load;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadScene(){
		SceneManager.LoadScene (load);
	}
}
