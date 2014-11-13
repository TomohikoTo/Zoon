using UnityEngine;
using System.Collections;

namespace zoon {

	public class CameraMover : MonoBehaviour, ICameraMoverController {

		public CameraMoverController controller;
		
		public void OnEnable() {
			controller.SetCameraMoverController (this);
		}
		
		// 初期化
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
			controller.CalcAngle();
			CameraRotation ();
		}

		public int CameraRotation() {
			this.transform.rotation = Quaternion.Euler (controller.GetAngle ());
			return 0;                                    
		}

	}

}
