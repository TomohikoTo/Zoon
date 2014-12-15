using UnityEngine;
using System.Collections;

namespace zoon {
	public class PlayData : MonoBehaviour {

	GameObject player;
	//GameObject SpawnPoint;
	public bool resetCheck = false;
	public float Life ;
	private LifeDisplayer ld;
	private ScoreDisplayer sd;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
			ld = GameObject.Find ("Life").GetComponent<LifeDisplayer>();
			sd = GameObject.Find ("Score").GetComponent<ScoreDisplayer>();
			//SpawnPoint = GameObject.FindWithTag("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {
	
			Life = ld.GetLife();
			//guiText.text = "HP"+ HP;
			if(Input.GetKey (KeyCode.P)){
				playReset();
			}
	}

	public void playReset(){
			
			ld.ResetLife ();
		//player.transform.position  = SpawnPoint.transform.position;

	}

}
}
