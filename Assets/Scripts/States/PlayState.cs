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


	//初期化
	public PlayState(GameStateManager GSManager) {
		
		manager = GSManager;
			psm = GameObject.Find ("Player").GetComponent<PlayerStateManager>();
			ld	= GameObject.Find ("Life").GetComponent<LifeDisplayer>();
			td	= GameObject.Find ("Timer").GetComponent<TimerDisplayer>();
			Life = ld.GetLife();
	}
		//更新処理
	public void StateUpdate() { 

		
		if(td.GetTime() > 0){
			TimeCourse();
		}
			GameEnd();
	}

		//描画等
		public void Render() { 
			
			
			
		}
	
	//-------PlayState固有メソッド--------

		//プレイ画面からリザルト画面に遷移する判定
		public void GameEnd(){
			//ライフが0以下になったら遷移
			if( ld.GetLife() <= 0){
				SwitchResult();  
				
			}

			//時間が0以下になったら遷移
			if( td.GetTime() <= 0){
				 
				SwitchResult();
			}

		}

		//プレイ時間の減少処理
		public void  TimeCourse(){

			td.ReduceTime();
		}


		//リザルト画面に遷移
		public void SwitchResult(){
			Application.LoadLevel("Result");
			Time.timeScale = 1;
			manager.SwitchState(new ResultState(manager)); 
		}


}
}