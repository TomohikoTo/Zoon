using UnityEngine;
using System.Collections;

namespace zoon {
public class PlayState : IState {
	// GameStateManagerのインスタンスを再利用

	public PlayData pd;
	private GameStateManager manager;
	public PlayerStateManager psm;

	public bool PositionReset = false;


	public PlayState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;
		
	}
	public void StateUpdate() { 

		psm = GameObject.Find ("Player").GetComponent<PlayerStateManager>();

		//更新処理
	//	if( psm.ReachGoal == true){
		//	Application.LoadLevel("Result");
	//		Time.timeScale = 1;
//manager.SwitchState(new ResultState(manager));  
	//		psm.ReachGoal = false;

	//	}

	}
		
		
	

		
		public void Render() { 
			//描画等


		}


}
}