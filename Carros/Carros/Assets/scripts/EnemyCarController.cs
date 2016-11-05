using UnityEngine;

using System.Collections;


public class EnemyCarController : MonoBehaviour {
		
	public float _lifeTime;
	PlayerCarController Play;
	Comand UpComand;
	public float Angle;
	Life_Car Car;

	void Start (){
		UpComand = new UpComand();
		Play = this.gameObject.GetComponent<PlayerCarController> ();
		Car = FindObjectOfType<Life_Car> ();
	}

	
	// Use this for initialization
	
	void OnEnable () {
		
		//
		//Invoke ("GotoSleep", _lifeTime);
	
	}

	
	public void GotoSleep(){
		
		gameObject.SetActive (false);	
	
	}

	
	// Update is called once per frame
	
 	void Update () {
		TruckCar();
		Vector3 Postion =Car.transform.position - transform.position;
		Angle = (Mathf.Rad2Deg * Mathf.Atan2 (Postion.z, Postion.x))-90;

		if (Angle > 5) {
			new LeftComand ().execute (Play);
		}
		if (Angle < -5) {
			new RightComand ().execute (Play);
		}
	}

	public void TruckCar(){


		UpComand.execute(Play);
	}

  	


	public void OnDisable(){

		CancelInvoke ();
	}

}
