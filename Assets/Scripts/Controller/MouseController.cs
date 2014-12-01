using UnityEngine;
using System;

namespace zoon{
[Serializable]
public class MouseController  {
	public string exTest = null;
	public string test = null;
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
			ThrowException();

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
	
	//例外テスト
		public virtual Boolean PressBackslash(){
			if (Input.GetKey (KeyCode.Backslash)) {
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
			//北西の方角
		if ( y != 315 && PressUpArrow() && PressLeftArrow() ){
			y = 315;
		}
			//北の方角
			if ( y != 0 && PressUpArrow() && ! PressRightArrow() && !PressLeftArrow()){
			y = 0;
		}
			//北東の方角
		if ( y != 45 && PressUpArrow() && PressRightArrow() ){
			y = 45;
		}
			//西の方角
			if ( y != 270 && PressLeftArrow()&& !PressUpArrow() && !PressDownArrow() ){
			y = 270;
		}
			//東の方角
			if ( y != 90 && PressRightArrow() && !PressUpArrow() && !PressDownArrow()){
			y = 90;
		}
			//南西の方角
		if ( y != 225 && PressLeftArrow() && PressDownArrow()){
			y = 225;
		}
			//南の方角
			if ( y != 180  && PressDownArrow() && ! PressRightArrow() && !PressLeftArrow()){
			y = 180;
		}
			//南東の方角
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
	public Vector3 GetException(){
			return this.position;
	}

	//エクセプションテストメソッド
	public void ThrowException(){
			if (PressBackslash()) {
				throw new ArgumentException("エラーが発生しました。");
			}
				 
	}
}
}
