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
	public TimerDisplayer td;
	public bool PositionReset = false;


	public PlayState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;
			psm = GameObject.Find ("Player").GetComponent<PlayerStateManager>();
			ld	= GameObject.Find ("Life").GetComponent<LifeDisplayer>();
			td	= GameObject.Find ("Timer").GetComponent<TimerDisplayer>();
			Life = ld.GetLife();
	}
	public void StateUpdate() { 

		
		//更新処理
			TimeCourse();
			GameEnd();
	}

		public void GameEnd(){
			if( ld.GetLife() <= 0){
				Application.LoadLevel("Result");
				Time.timeScale = 1;
				manager.SwitchState(new ResultState(manager));  
				
			}

			if( td.GetTime() <= 0){
				Application.LoadLevel("Result");
				Time.timeScale = 1;
				manager.SwitchState(new ResultState(manager));  
				
			}

		}

		public void  TimeCourse(){

			td.ReduceTime();
		}
		
	

		
		public void Render() { 
			//描画等


		}


}
}