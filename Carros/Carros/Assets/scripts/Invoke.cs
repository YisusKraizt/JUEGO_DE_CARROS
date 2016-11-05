using UnityEngine;
using System.Collections;

public class Invoke : MonoBehaviour {

	public KeyCode _KeyAccelerate;
	public KeyCode _keyRight;
	public KeyCode _keyLeft;
	public KeyCode _keyBack;

	PlayerCarController Play;

	Comand UpComand;
	Comand DownComand;
	Comand LeftComand;
	Comand rightComand;
	Comand Stopcomand;

	void Start (){
		UpComand = new UpComand();
		DownComand = new DownComand ();
		LeftComand = new LeftComand ();
		rightComand = new RightComand ();
		Stopcomand = new StopComand ();

		Play = this.gameObject.GetComponent<PlayerCarController> ();
	}

	void Update(){
		Keys ();

	}

	public void Keys(){

		if (Input.GetKey (_KeyAccelerate)) {
			UpComand.execute (Play);
		}
		else if (Input.GetKey (_keyBack)) {
			DownComand.execute (Play);
		}else {
			Stopcomand.execute (Play);
			}
			
		if (Input.GetKey(_keyRight)){
			rightComand.execute(Play);
		}
		if (Input.GetKey(_keyLeft)){
			LeftComand.execute(Play);
		}
	}
}
