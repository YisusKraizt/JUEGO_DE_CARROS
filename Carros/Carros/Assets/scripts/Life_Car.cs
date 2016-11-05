using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Life_Car : MonoBehaviour {
	public int life_car;
	private int Count=0;
	public int Lap=0;
	GameObject text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnCollisionEnter(Collision Car)
	{
		Debug.Log ("choca contra un enemigo");

		if (Car.transform.tag == "enemy_car") {
			life_car--;
			if (life_car <= 0) {
				Debug.Log ("has muerto");
				life_car = 0;
				SceneManager.LoadScene ("test_01 Object Pool");
			}

		}
	}

	void OnTriggerEnter(Collider colision){
		Debug.Log ("dio la vuelta");
		if (colision.tag == "lap") {
			if (colision.gameObject.GetComponent<Lap_trigger> ().id == Count + 1) {
				Count++;
				if (colision.gameObject.GetComponent<Lap_trigger> ().end_lap)
					Lap++;
			}
		}
	}
		
}