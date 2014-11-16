using UnityEngine;
using System;

namespace zoon {
	
	[Serializable]
	public class CameraMoverController
	{
		private float x = 0.0f;
		private float y = 0.0f;
		private float z = 0.0f;

		public Vector3 angle = Vector3.zero;
		public Vector3 cPosition = Vector3.zero;
		
		public ICameraMoverController cameraMoverController;
		
		public CameraMoverController (){
		}
		
		public void SetCameraMoverController(ICameraMoverController cameraMoverController) {
			this.cameraMoverController = cameraMoverController;
		}

		public void CalcAngle() {
			CalcAngleX ();
			CalcAngleY ();
			SetAngle ();
		}

		public virtual Boolean IsClickedQ(){
			if (Input.GetKey (KeyCode.Q)) {		
				return true;
			}
			return false;
		}

		public virtual Boolean IsClickedE(){
			if (Input.GetKey (KeyCode.E)) {		
				return true;
			}
			return false;
		}

		public virtual Boolean IsClickedR(){
			if (Input.GetKey (KeyCode.R)) {		
				return true;
			}
			return false;
		}

		public virtual Boolean IsClickedF(){
			if (Input.GetKey (KeyCode.F)) {		
				return true;
			}
			return false;
		}

		private void CalcAngleY() {

			if (IsClickedQ()) {
				y -= 5f;
			}
			if (IsClickedE ()) {
				y += 5f;
			}
		}

		private void CalcAngleX() {

			if (IsClickedR ()) {
				if (x > -30) {
					x -= 5f;
				}
				
			}
			if (IsClickedF ()) {
				if (x < 30) {
					x += 5f;
				}
			}
		}

		public Vector3 GetAngle() {
			return this.angle;
		}

		public void SetAngle() {
			this.angle.x = x;
			this.angle.y = y;
			this.angle.z = z;
		}

		public float GetY() {
			return y;
		}

		public float GetX() {
			return x;
		}

	}
	
	
}