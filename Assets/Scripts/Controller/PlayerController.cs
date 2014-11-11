using UnityEngine;
using System.Collections;

public class PlayerController {


	private float x = 0.0f;
	private float y = 0.0f;
	private float z = 0.0f;
	private bool landing = true;
	public Vector3 position = Vector3.zero;
	public IntPlayerController playerController;

	public PauseState ps;
	public float AnimState = 0;
	private int WalkId;
	public bool Jump = false;
	GameObject Player;
	public float JumpSpeed = 1000.0f;
		public float BaseSpeed = 0.1f;
	public float MoveSpeed = 0.1f;
	public float DashSpeed = 2.0f;
	public float MaxSpeed = 1.0f;
	public float MinSpeed = 0.0f;
	[HideInInspector]
	public float PlayerSpeed;
	public PlayerController (){
	}
	public void SetPlayerController(IntPlayerController playerController) {
		this.playerController = playerController;
	}
	// Use this for initialization



	public void PlayerMove() {
		MoveX ();
		MoveY ();
		SetPosition ();
	}
	// Update is called once per frame
	public void Update () {
		if( !Jump && Input.GetKey(KeyCode.RightControl) && MaxSpeed > MoveSpeed){
			MoveSpeed *= DashSpeed;
		} else if(Input.GetKeyUp(KeyCode.RightControl) || Jump){
			MoveSpeed = BaseSpeed;
		}



	//	if( player.transform.position.y < -50){
	//		player.transform.position  = SpawnPoint.transform.position;

	//	}
	
	}



	//プレイヤーのキー入力関連
	public virtual bool PressLeftArrow(){
		if (Input.GetKey (KeyCode.LeftArrow)) {
			return true;
		}
		return false;
	}
	public virtual bool PressRightArrow(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			return true;
		}
		return false;
	}
	public virtual bool PressUpArrow(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			return true;
		}
		return false;
	}
	public virtual bool PressDownArrow(){
		if (Input.GetKey (KeyCode.DownArrow)) {
			return true;
		}
		return false;
	}

	public virtual bool PressW(){
		if ( landing && Input.GetKey (KeyCode.W)) {
			landing = false;
			return true;
		}
		return false;
	}

	public virtual bool PressD(){
		if ( landing && Input.GetKey (KeyCode.D) && MaxSpeed > MoveSpeed) {
			MoveSpeed *= DashSpeed;
			return true;
		}
		return false;
	}
	//プレイヤーのＸ軸移動
	private void MoveX() {
		if (PressLeftArrow() ) {

				x -= MoveSpeed;

		}
		if ( PressRightArrow()) {
			x += MoveSpeed;
		}
	}
	private void MoveZ() {
		if (PressUpArrow()) {
			z += MoveSpeed;
		}
		if (PressDownArrow()) {
			z -= MoveSpeed;
		}
	}

	private void MoveY() {

		if (PressW()) {
			y += JumpSpeed;
		}
	}
	public void SetPosition() {
		this.position.x = x;
		this.position.y = y;
		this.position.z = z;
	}
	public Vector3 GetPosition(){
		return this.position;
	}

	public float GetX() {
		return x;
	}

	public float GetY() {
		return y;
	}

	public float GetZ() {
		return z;
	}

	public bool SetLanding() {
		return this.landing = true;
	}
	public bool GetLanding() {
		return this.landing;
	}
}