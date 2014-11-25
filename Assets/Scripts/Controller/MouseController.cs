using UnityEngine;
using System;

public class MouseController  {

	private float x = 0.0f;
	private float y = 0.0f;
	private float z = 0.0f;
	public float MoveSpeed = 0.5f;
	public Vector3 position = Vector3.zero;
	public Vector3 rotation = Vector3.zero;
	public IMouseController imcon;


	public MouseController (){
	}
	public void SetMouseController(IMouseController imcon) {
		this.imcon = imcon;
	}

	public void MouseMove(){
		MoveX();
		MoveY();
		MoveZ();
		SetRotation();
		SetPosition();

	}

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

	//プレイヤーの向きのメソッド
	private void MoveY() {
		//7
		if ( y != 315 && PressUpArrow() && PressLeftArrow() ){
			y = 315;
		}
		//8
		if ( y != 0 && PressUpArrow()){
			y = 0;
		}
		//9
		if ( y != 45 && PressUpArrow() && PressRightArrow() ){
			y = 45;
		}
		//4
		if ( y != 270 && PressLeftArrow() ){
			y = 270;
		}
		//6
		if ( y != 90 && PressRightArrow() ){
			y = 90;
		}
		//1
		if ( y != 225 && PressLeftArrow() && PressDownArrow()){
			y = 225;
		}
		//2
		if ( y != 180  && PressDownArrow()){
			y = 180;
		}
		//3
		if ( y != 135  && PressDownArrow()&& PressRightArrow()){
			y = 135;
		}

	}

	//プレイヤーの位置のセッター
	public void SetPosition() {
		this.position.x = x;
		this.position.z = z;
	}

	//プレイヤーの向きのセッター
	//プレイヤーのポジションのセッター
	public void SetRotation() {
		this.rotation.y = y;
	}
	public Vector3 GetPosition(){
		return this.position;
	}
	public Vector3 GetRotation(){
		return this.rotation;
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
}
