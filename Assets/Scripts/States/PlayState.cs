using UnityEngine;
using System.Collections;

namespace zoon {

	public class PlayState : StateInt {
		// GameStateManagerのインスタンスを再利用
		private GameStateManager manager;
		public PlayerStateManager psm;
		GameObject player;
			

		public PlayState(GameStateManager GSManager) {
			//初期化
			manager = GSManager;

		}
		
		public void StateUpdate() { 
			psm = GameObject.Find ("Player").GetComponent<PlayerStateManager>();
			//更新処理
			if( psm.ReachGoal == true){
				Application.LoadLevel("Result");
				Time.timeScale = 1;
				manager.SwitchState(new ResultState(manager));  
				psm.ReachGoal = false;

			}
			
			if(Input.GetKeyUp(KeyCode.Escape)) {
				Application.LoadLevel("Menu");
				
				manager.SwitchState(new MenuState(manager));  
				player = GameObject.Find("Player");
				Object.Destroy(player);
			}
		}
		
		public void Render() { 
			//描画等


		}
	}

}