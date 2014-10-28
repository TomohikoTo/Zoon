using UnityEngine;
using System.Collections;

public class PlayerStateManager : MonoBehaviour {
		
		//ゲームの状態を保持
		private PlayerInt activeState;
		public bool landing = true;
		public static PlayerStateManager instance;
		
		void Awake()
		{
			
			if(instance == null) {
				instance = this;
				DontDestroyOnLoad(gameObject);
			} else {
				DestroyImmediate(gameObject);
			}
			
		}
		

		
		void Start()
		{
			activeState = new HumanState(this);
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
	}
