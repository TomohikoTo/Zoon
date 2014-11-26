using UnityEngine;
using System.Collections;
using System.Collections.Generic;



namespace zoon {
	public class HumanState :  IPlayerState   {

		

		GameObject player;
		GameObject SpawnPoint;
		public bool ReachGoal = false;
		private Animator animator;
		public bool landing = false;
		GameObject Player;
		public float JumpSpeed = 1000.0f;
		public float BaseSpeed = 0.1f;
		public float MoveSpeed = 0.1f;
		public float DashSpeed = 2.0f;
		public float MaxSpeed = 0.4f;
		public float MinSpeed = 0.0f;
		[HideInInspector]
		public float PlayerSpeed;
		private PlayerStateManager manager;
		private GameStateManager GSManager;
		public HumanState(PlayerStateManager PSManager) {
			//初期化
			manager = PSManager;
			player = GameObject.Find("Player");
			SpawnPoint = GameObject.FindWithTag("SpawnPoint");
			
		}
		public void OnEnable(){
		}
		// Use this for initialization
		public void Update() { 
			//更新処理
			if( manager.landing && Input.GetKey(KeyCode.RightControl) && MaxSpeed > MoveSpeed){
				MoveSpeed *= DashSpeed;
			} else if(Input.GetKeyUp(KeyCode.RightControl) ){
				MoveSpeed = BaseSpeed;
			}
			
			//transform.Translate(Vector3.forward * PlayerSpeed * 0.01f);
			//x軸移動
			if(Input.GetKey(KeyCode.LeftArrow)){
				player.transform.Translate(-MoveSpeed,0.0f,0.0f);
				/*if( transform.rotation.y != 45){
					transform.Rotate(0.0f,2f,0.0f);
				} else if(transform.rotation.y == 90){
				}
				*/
			}
			if(Input.GetKey(KeyCode.RightArrow)){
				player.transform.Translate(MoveSpeed,0.0f,0.0f);
			}
			//ピッチ運動
			if(Input.GetKey(KeyCode.UpArrow)){
				player.transform.Translate(0.0f,0.0f,MoveSpeed);
			}
			if(Input.GetKey(KeyCode.DownArrow)){
				player.transform.Translate(0.0f,0.0f,-MoveSpeed);
			}
			if( manager.landing && Input.GetKey(KeyCode.Space)){
				manager.SwitchState(new BirdState(manager));    
			}
			
			// ジャンプ中でないときにマウス左ボタンが押されたらジャンプする
			if (manager.landing && Input.GetKey(KeyCode.W))
			{
				manager.landing = false;
				// オブジェクトの上方向に力を瞬間的に与える
				player.rigidbody.AddForce(Vector3.up * JumpSpeed);
			}

			
			if( player.transform.position.y < -50){
				//player.transform.position  = SpawnPoint.transform.position;
				
			}
			
		}
		
		private void OnCollisionEnter(Collision collision)
		{
			// 床オブジェクトと衝突したらジャンプ中ではないのでjump = falseにする
			if (collision.gameObject.tag == "Floor")
			{
				manager.landing = true;
			}
			
			if (collision.gameObject.tag == "Goal")
			{
				ReachGoal = true;
				
			}
		}



}
}