using UnityEngine;
using System.Collections;

namespace zoon{
public class PlayerStateManager : MonoBehaviour , IPlayerStateManagerController {
		
		//ゲームの状態を保持
		//public Transform from;
		//public Transform to;
		public float speed = 0.1F;
		[HideInInspector]
		public PlayerStateManagerController psmcon;
		public IPlayerState activeState;
		public bool landing = false;
		public bool ReachGoal = false;
		public static PlayerStateManager psm;
		GameObject player;
		GameObject SpawnPoint;
		void OnEnable()
		{
		}
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
				activeState = new MouseState(this);
				player = GameObject.Find("Player");
				//SpawnPoint = GameObject.FindWithTag("SpawnPoint");
				//player.transform.position  = SpawnPoint.transform.position;
				
			}
			void Update()
			{
				if(activeState != null)
				{
					//activeState.OnEnable();
					activeState.StateUpdate();
				}
			}
		
		public string SwitchState(IPlayerState newState) 
		{
			activeState = newState;
			Debug.Log (activeState);
			return activeState.ToString ();	
		}
	public void PlayerStateManagerInit()
	{
		activeState = new MouseState(this);
		
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

			
		}

	private void OnCollisionExit(Collision collision)
	{
		// 床オブジェクト衝突したらジャンプ中ではないのでjump = falseにする
		if (collision.gameObject.tag == "Floor")
		{
			landing = false;
		}
		

		
		
	}
		public string FormatState(){
			return psmcon.GetStateName ();
		}
		void OnBecameInvisible() {
			if(ReachGoal)
			enabled = false;
		}
	}
}
