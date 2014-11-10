using UnityEngine;
using System.Collections;

namespace zoon {

	public class PlayerStateManager : MonoBehaviour {
			
			//ゲームの状態を保持
			private PlayerInt activeState;
			public bool HaveFeather = false;
			public bool landing = false;
			public bool ReachGoal = false;
			public static PlayerStateManager psm;
			GameObject player;
			GameObject SpawnPoint;
			void Awake()
			{
				
			if(psm == null) {
				psm = this;
					DontDestroyOnLoad(gameObject);
				} else {
					DestroyImmediate(gameObject);
				}
				
			}
			

			
			void Start()
			{
				activeState = new HumanState(this);
				player = GameObject.Find("Player");
				SpawnPoint = GameObject.FindWithTag("SpawnPoint");
				player.transform.position  = SpawnPoint.transform.position;
				
			}
			void Update()
			{
				if(activeState != null)
					activeState.StateUpdate();
			}
			public void SwitchState(PlayerInt newState) 
			{
				activeState = newState;
			}

		private void OnCollisionEnter(Collision collision)
		{
			// 床オブジェクトと衝突したらジャンプ中ではないのでjump = falseにする
			if (collision.gameObject.tag == "Floor")
			{
				landing = true;
			}
			
			if (collision.gameObject.tag == "Goal")
			{
				ReachGoal = true;

				
			}

			if(collision.gameObject.tag == "Block")
			{
				HaveFeather = true;
			}

		}
		void OnBecameInvisible() {
			if(ReachGoal)
			enabled = false;
		}
	}

}
