using UnityEngine;
using System.Collections;

namespace zoon {
	public class PlayData : MonoBehaviour {

	GameObject player;
	GameObject SpawnPoint;
	private GameStateManager manager;
	public bool resetCheck = false;
	public float Life ;
	private LifeDisplayer ld;
	private ScoreDisplayer sd;

	// Use this for initialization
	void Start () {
			manager = GameObject.Find ("GameManager").GetComponent<GameStateManager>();
			player = GameObject.Find("Player");
			ld = GameObject.Find ("Life").GetComponent<LifeDisplayer>();
			sd = GameObject.Find ("Score").GetComponent<ScoreDisplayer>();

	}
	
	// Update is called once per frame
	void Update () {
	
			Life = ld.GetLife();
			//guiText.text = "HP"+ HP;
			PositionReset();
			if(Input.GetKey (KeyCode.P)){
				PlayReset();
			}
	}

	public void PositionReset(){
			//if(manager.FormatState() == "PlayState"){
			//	SpawnPoint = GameObject.FindWithTag("SpawnPoint");
			//	print (SpawnPoint);
			 // }
	}
	public void PlayReset(){
			
			ld.ResetLife ();
			sd.ResetScore ();


		//player.transform.position  = SpawnPoint.transform.position;

	}

}
}
