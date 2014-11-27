using UnityEngine;
using System.Collections;
namespace zoon {
public class PlayerMover : MonoBehaviour, IntPlayerController {

	GameObject player;
	GameObject spawnPoint;
	public Vector3 direction ;
	public PlayerController pcont;
//	private bool ReachGoal = false;

	public void OnEnable() {
		pcont.SetPlayerController (this);
	}


	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		spawnPoint = GameObject.FindWithTag("SpawnPoint");
	}
	private void FixedUpdate()
	{
		// ジャンプ中でないときにマウス左ボタンが押されたらジャンプする
		if (pcont.SetJump())
		{

			// オブジェクトの上方向に力を瞬間的に与える
			rigidbody.AddForce(transform.up * pcont.GetJump(), ForceMode.Impulse);
		}
	}

	// Update is called once per frame
	void Update () {


	
		pcont.PlayerMove();
		pcont.HumanSkill();
		PlayerTranslation ();
	}
	

	
	public int PlayerTranslation() {

		this.transform.position = (pcont.GetPosition ());

		return 0;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Floor")
		{
			pcont.SetLanding ();
			
		}
		
		if (collision.gameObject.tag == "Goal")
		{
			//ReachGoal = true;
			
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		// 床オブジェクトと衝突したらジャンプ中ではないのでjump = falseにする
		if (collision.gameObject.tag == "Floor")
		{
			pcont.ExitLanding ();
			
		}
	}
}
}
