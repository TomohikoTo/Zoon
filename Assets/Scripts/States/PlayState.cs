using UnityEngine;
using System.Collections;

namespace zoon {
public class PlayState : IState {
	// GameStateManagerのインスタンスを再利用
		public float Life ;
	public PlayData pd;
	private GameStateManager manager;
	public PlayerStateManager psm;
	public LifeDisplayer ld;
	public bool PositionReset = false;


	public PlayState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;
			psm = GameObject.Find ("Player").GetComponent<PlayerStateManager>();
			ld	= GameObject.Find ("Life").GetComponent<LifeDisplayer>();
			Life = ld.GetLife();
	}
	public void StateUpdate() { 

		
		//更新処理
		if( ld.GetLife() <= 0){
			Application.LoadLevel("Result");
			Time.timeScale = 1;
	manager.SwitchState(new ResultState(manager));  
	
		}
	}
		
		
	

		
		public void Render() { 
			//描画等


		}


}
}