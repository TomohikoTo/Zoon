using UnityEngine;
using System.Collections;



	public class GameStateManager : MonoBehaviour {

		//ゲームの状態を保持
		private StateInt activeState;

		public static GameStateManager instance;
		
		void Awake()
		{

			if(instance == null) {
				instance = this;
				DontDestroyOnLoad(gameObject);
			} else {
				DestroyImmediate(gameObject);
			}
			
		}
		
		void OnGUI()
		{
			activeState.Render();
		}
		
		void Start()
		{
			activeState = new TitleState(this);
		}
		void Update()
		{
			if(activeState != null)
				activeState.StateUpdate();
		}
		public void SwitchState(StateInt newState) 
		{
			activeState = newState;
		}


}