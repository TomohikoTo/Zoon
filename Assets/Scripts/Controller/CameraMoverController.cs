using UnityEngine;
using System;

namespace zoon {
	
	[Serializable]
	public class CameraMoverController
	{

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
		}

		public Boolean IsClickedQ(){
			if (Input.GetKey (KeyCode.Q)) {		
				return true;
			}
			return false;
		}

		public Boolean IsClickedE(){
			if (Input.GetKey (KeyCode.E)) {		
				return true;
			}
			return false;
		}

		public Boolean IsClickedR(){
			if (Input.GetKey (KeyCode.R)) {		
				return true;
			}
			return false;
		}

		public Boolean IsClickedF(){
			if (Input.GetKey (KeyCode.Q)) {		
				return true;
			}
			return false;
		}

		private void CalcAngleY() {

			if (IsClickedQ()) {
				angle.y -= 5f;
			}
			if (IsClickedE ()) {
				angle.y += 5f;
			}
		}

		private void CalcAngleX() {

			if (IsClickedR ()) {
				if (angle.x > -30) {
					angle.x -= 5f;
				}
				
			}
			if (IsClickedF ()) {
				if (angle.x < 30) {
					angle.x += 5f;
				}
			}
		}

		public Vector3 GetAngle() {
			return this.angle;
		}

		public float GetAngleY() {
			return this.angle.y;
		}

		public float GetAngleX() {
			return this.angle.x;
		}

	}
	
	
}