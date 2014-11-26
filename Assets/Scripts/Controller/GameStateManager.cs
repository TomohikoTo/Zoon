using UnityEngine;
using System.Collections;


namespace zoon {
public class GameStateManager : MonoBehaviour , IGameStateManagerController {

		//ゲームの状態を保持
	public IState activeState;
	[HideInInspector]
	public GameStateManagerController gsmcon;

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
			GameStateManagerInit();
		}
		void Update()
		{
		//activeStateがnullでないならactiveStateのStateUpdateメソッドを実行
			if(activeState != null)
				activeState.StateUpdate();
		}
		//単体テスト用に修正
		public string SwitchState(IState newState) 
		{
			activeState = newState;
			Debug.Log (activeState);
			return activeState.ToString ();

		}

		public void GameStateManagerInit()
	{
		activeState = new TitleState(this);

	}

	public string FormatState(){
		return gsmcon.GetStateName ();
	}
}
}