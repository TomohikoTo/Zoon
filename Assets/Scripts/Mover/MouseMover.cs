using UnityEngine;
using System;

namespace zoon{
public class MouseMover : MonoBehaviour , IMouseController {
		private float LifePoint = 1f;
		private float ScorePoint = 10f;
		LifeDisplayer ld;
		ScoreDisplayer sd;
		public float speed = 3.0f;
		public MouseController mcon;
		GameObject player;
		public void OnEnable() {
			mcon.SetMouseController(this);
		}

		// Use this for initialization
		void Start () {
			ld	= GameObject.Find("Life").GetComponent<LifeDisplayer>();
			sd	= GameObject.Find("Score").GetComponent<ScoreDisplayer>();
			player = GameObject.Find("Player");

		}
		
		public void StateUpdate(){

			Update ();

		}
		// Update is called once per frame
		public void Update () {
			ExceptionCheck();

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
		private void OnCollisionEnter(Collision collision)
		{
			// プレイヤーがチーズに接触したら消滅
			if (collision.gameObject.name == "cat")
			{
				ld.ReduceLife(LifePoint);

			}
			if (collision.gameObject.name == "bad_mouse")
			{
				sd.ReduceScore(ScorePoint);
				
			}
			
			
			
			
			
		}
		public void ExceptionCheck(){
		
		try { 

				mcon.MouseMove();
				MouseTranslation ();
				MouseRotation ();

			} catch (ArgumentException e) {
			Debug.Log (e);
		} finally{

			}
		}
}
}