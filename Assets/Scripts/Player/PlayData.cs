using UnityEngine;
using System.Collections;

namespace zoon {

<<<<<<< HEAD
	GameObject player;
	GameObject SpawnPoint;
	public bool resetCheck = false;
	public float HP ;
	public enum AnimalState{
		   Human,
		   Bird,
	 };

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		SpawnPoint = GameObject.FindWithTag("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {
	
	
			guiText.text = "HP"+ HP;
	
	}

	public void playReset(){

		player.transform.position  = SpawnPoint.transform.position;
=======
	public class PlayData : MonoBehaviour {


		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
>>>>>>> TB
	}

}
