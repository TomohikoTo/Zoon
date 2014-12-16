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
	//ゲームの制限時間
	private float gameTime = 0.0f;
	private float initialTime = 30.0f;
	
		void start(){
			gameTime = 0.0f;
		}

		//ポイント獲得
		public float AddTime(float TimePoint){
			return gameTime += TimePoint;
		}
		
		//ポイント減少
		public float ReduceTime(){

			return gameTime -= Time.deltaTime;
		}
		public float TimeReset(){
			return gameTime = initialTime;
		}

		public float GetTime(){
			return gameTime;
		}
		public string SetTime () {
			
			return gameTime.ToString();
		}
	}
}