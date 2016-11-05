using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GUI_Controller : MonoBehaviour {

	public Life_Car Car;

	public Text life_text;
	public Text lap_text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		life_text.text = "" + Car.life_car;
		lap_text.text =" "+Car.Lap;
	}
}
