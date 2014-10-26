using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {
	public Vector3 angle = Vector3.zero;
	public Vector3 cPosition = Vector3.zero;

	// 初期化
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Q)){
			//if( angle.y > -40){
				angle.y -= 5f;
				//cPosition.z += 0.02f;
			//}
		
		}
		if(Input.GetKey(KeyCode.E)){
			//if( angle.y < 40){
				angle.y += 5f;
				//cPosition.z -= 0.02f;
		//	}

		}
		if(Input.GetKey(KeyCode.R)){
			if( angle.x > -30){
				angle.x -= 5f;
				//cPosition.z -= 0.02f;
			}
			
		}
		if(Input.GetKey(KeyCode.F)){
			if( angle.x < 30){
				angle.x += 5f;
				//cPosition.z -= 0.02f;
			}
			
		}
		this.transform.rotation = Quaternion.Euler (angle.x, angle.y, angle.z);
		//this.transform.Translate(cPosition.x, cPosition.y, cPosition.z);
	}
}
