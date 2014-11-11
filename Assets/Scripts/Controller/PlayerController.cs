using UnityEngine;
using System;

[Serializable]
public class PlayerController {
	private float x = 0.0f;
	private float y = 0.0f;
	private float z = 0.0f;
	public bool landing = true;
	public Vector3 position = Vector3.zero;
	public IntPlayerController playerController;

	public PauseState ps;
	public float AnimState = 0;
	private float JumpMove = 0.0f;
	public float JumpSpeed = 10.0f;
	public float BaseSpeed = 0.1f;
	public float MoveSpeed = 0.1f;
	public float DashSpeed = 2.0f;
	public float MaxSpeed = 1.0f;
	public float MinSpeed = 0.0f;
	[HideInInspector]
	public float PlayerSpeed = 0.1f;
	public PlayerController (){
	}
	public void SetPlayerController(IntPlayerController playerController) {
		this.playerController = playerController;
	}
	// Use this for initialization



	public void PlayerMove() {
		MoveX ();
		MoveZ ();
		SetPosition ();

	}
	
	public void HumanSkill() {
		Dash();
		GetLanding();
		Jump();
		SetSpeed ();
		SetJump ();
	}


	//プレイヤーのキー入力関連
	//左へ移動
	public virtual Boolean PressLeftArrow(){
		if (Input.GetKey (KeyCode.LeftArrow)) {
			return true;
		}
		return false;
	}
	//右へ移動
	public virtual Boolean PressRightArrow(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			return true;
		}
		return false;
	}
	//前へ移動
	public virtual Boolean PressUpArrow(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			return true;
		}
		return false;
	}
	//後ろへ移動
	public virtual Boolean PressDownArrow(){
		if (Input.GetKey (KeyCode.DownArrow)) {
			return true;
		}
		return false;
	}
	//ジャンプ
	public virtual Boolean PressW(){
		if ( landing && Input.GetKey (KeyCode.W)) {
			return true;
		}
		return false;
	}
	//ダッシュ
	public virtual Boolean PressD(){
		if ( landing && Input.GetKey (KeyCode.D) && MaxSpeed > MoveSpeed) {
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
	//プレイヤーのＺ軸移動
	private void MoveZ() {
		if (PressUpArrow()) {
			z += MoveSpeed;
		}
		if (PressDownArrow()) {
			z -= MoveSpeed;
		}
	}
	//プレイヤーのＹ軸移動
	private void Jump() {
		if (PressW()) {
			//landing = false;
			JumpMove += JumpSpeed;
		}
	}
	//ダッシュによる移動速度の上昇
	private void Dash() {
		if (PressD ()) {
			MoveSpeed *= DashSpeed;
		}
	}


	//プレイヤーの移動速度のセッター
	public void SetSpeed() {
		this.PlayerSpeed = MoveSpeed;
	}
	//プレイヤーのポジションのセッター
	public void SetPosition() {
		this.position.x = x;
		this.position.y = y;
		this.position.z = z;
	}

	public Vector3 GetPosition(){
		return this.position;
	}
	public float GetSpeed(){
		return PlayerSpeed;
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

	public Boolean SetJump(){
		return true;
	}
	public float GetJump(){
		return this.JumpMove;
	}
	public void SetLanding() {
		landing = true;
	}
	public bool GetLanding() {
		return this.landing;
	}
}
