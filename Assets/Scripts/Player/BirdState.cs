using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class BirdState : PlayerInt  {
	Texture2D bird_icon ;
	public PauseState ps;
	public float AnimState = 0;
	GameObject player;
	GameObject boy;
	GameObject SpawnPoint;
	public float MoveSpeed = 0.1f;
	private PlayerStateManager manager;
	
	public BirdState(PlayerStateManager PSManager) {
		//初期化
		manager = PSManager;
		player = GameObject.Find("Player");
=======
namespace zoon {
>>>>>>> TB

	public class BirdState : MonoBehaviour , PlayerInt  {
		public PauseState ps;
		public float AnimState = 0;
		GameObject player;
		GameObject boy;
		GameObject SpawnPoint;
		public float MoveSpeed = 0.1f;
		private PlayerStateManager manager;
		
		public BirdState(PlayerStateManager PSManager) {
			//初期化
			manager = PSManager;
			player = GameObject.Find("Player");

			SpawnPoint = GameObject.FindWithTag("SpawnPoint");
			
		}
		
		// Update is called once per frame
		public void StateUpdate() { 
			//更新処理

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
			if (Input.GetKey(KeyCode.W))
			{

				// オブジェクトの上方向に力を瞬間的に与える
				if( manager.landing)
					manager.landing = false;
				player.rigidbody.AddForce(Vector3.up * 30);
			}
			if (Input.GetKey(KeyCode.S))
			{
				
				// オブジェクトの上方向に力を瞬間的に与える
				if( !manager.landing)
				player.rigidbody.AddForce(Vector3.down * 30);
			}
			if(Input.GetKey(KeyCode.Space)){
				manager.SwitchState(new HumanState(manager));    
			}
		}
	}
<<<<<<< HEAD
	void OnGUI() {

		
		GUI.DrawTexture(
			new Rect(10,10,60,60), bird_icon, 
			ScaleMode.ScaleToFit, true, 10.0f);
	}
	public void Render(){
	}
=======

>>>>>>> TB
}
