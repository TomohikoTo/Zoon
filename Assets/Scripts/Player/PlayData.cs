using UnityEngine;
using System.Collections;

namespace zoon {
	public class PlayData : MonoBehaviour {

	GameObject player;
	//GameObject SpawnPoint;
	public bool resetCheck = false;
	public float Life ;
		private LifeDisplayer ld;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		ld = GameObject.Find ("Life").GetComponent<LifeDisplayer>();
		//SpawnPoint = GameObject.FindWithTag("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {
	
			Life = ld.GetLife();
			//guiText.text = "HP"+ HP;
	
	}

	public void playReset(){

		//player.transform.position  = SpawnPoint.transform.position;

	}

}
}
