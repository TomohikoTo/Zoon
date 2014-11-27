using UnityEngine;
using System;

namespace zoon{
public class MouseMover : MonoBehaviour , IMouseController {
	
		public float speed = 3.0f;
		public MouseController mcon;
		GameObject player;
		public void OnEnable() {
			mcon.SetMouseController(this);
		}

		// Use this for initialization
		void Start () {
			player = GameObject.Find("Player");

		}
		
		public void StateUpdate(){

			Update ();

		}
		// Update is called once per frame
		public void Update () {
			ExceptionCheck();
			mcon.MouseMove();
			MouseTranslation ();
			MouseRotation ();
		}
		public int MouseTranslation() {
			this.transform.position = (mcon.GetPosition ());
			player.transform.position = (mcon.GetPosition ());
			
			return 0;
		}
		
		public int MouseRotation() {
			this.transform.rotation = Quaternion.Euler (mcon.GetRotation()); 
			player.transform.rotation = Quaternion.Euler (mcon.GetRotation()); 
			
			
			return 0;
		}

		public void ExceptionCheck(){
		
		try { 
				mcon.ThrowException();

			} catch (NullReferenceException e) {
			Debug.Log (e);
		} finally{

			}
		}
}
}