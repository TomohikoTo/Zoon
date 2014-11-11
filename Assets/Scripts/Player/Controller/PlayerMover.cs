using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour, IntPlayerController {

	GameObject player;
	GameObject spawnPoint;
	public PlayerController pcont;
	private bool ReachGoal = false;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		spawnPoint = GameObject.FindWithTag("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {
		pcont.PlayerMove();
		PlayerTranslation ();
	}
	
	public void OnEnable() {
		pcont.SetPlayerController (this);
	}
	
	public int PlayerTranslation() {
		this.transform.position = (pcont.GetPosition ());
		return 0;
	}

	private void OnCollisionEnter(Collision collision)
	{
		// 床オブジェクトと衝突したらジャンプ中ではないのでjump = falseにする
		if (collision.gameObject.tag == "Floor")
		{
			//pcont.SetLanding ();

		}
		
		if (collision.gameObject.tag == "Goal")
		{
			ReachGoal = true;
			
		}
	}
	
}
