using UnityEngine;
using System.Collections;

public class PlayData : MonoBehaviour {
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
	
	
	}

	public void playReset(){

		player.transform.position  = SpawnPoint.transform.position;
	}
}
