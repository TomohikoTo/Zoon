using UnityEngine;
using System;

namespace zoon {
	[Serializable]
public class TimerController  {

	//初期化処理
	public ITimerController itcon;
	public TimerController(){
			
	}
	public void SetTimerController(ITimerController itcon){
			this.itcon = itcon;

	}
	
	private float gameTime = 0.0f;		//ゲームの制限時間
	private float initialTime = 30.0f;	//制限時間の初期時間
	
	
	void start(){
			gameTime = 0.0f;
	}

		//ポイント獲得
		public float AddTime(float TimePoint){
			return gameTime += TimePoint;
		}
		
		//ポイント減少
		public float ReduceTime(){
			if( gameTime > 0){
			return gameTime -= Time.deltaTime;
			}
			return gameTime;
		}

		//時間の初期化
		public float TimeReset(){
			return gameTime = initialTime;
		}

		//時間のゲッター
		public float GetTime(){
			return gameTime;
		}

		//時間を画面に表示するためのセッター
		public string SetTime () {
			
			return gameTime.ToString();
		}
	}
}