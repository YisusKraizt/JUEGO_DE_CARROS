using UnityEngine;
using System.Collections;

public class TaxiInvoker : MonoBehaviour {

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
		//executeRandomComand ();
		PlayComands();
	}

	public void executeRandomComand(){
		int random = Mathf.RoundToInt(Random.value * 10);
		Debug.Log ("genera el random" + random);
		if (random >3) {
			UpComand.execute (Play);
		}
		else if (random >0) {
			DownComand.execute (Play);
		}else {
			Stopcomand.execute (Play);
		}

		if (random >6){
			rightComand.execute(Play);
		}
		if (random <4){
			LeftComand.execute(Play);
		}
	}

	public void PlayComands(){
	//	Invoker.ListComands;
	}
}
