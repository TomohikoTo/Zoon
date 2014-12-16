using UnityEngine;
using System.Collections;

namespace zoon {
public class TimerDisplayer : MonoBehaviour , ITimerController {

		public TimerController tcon;

		public void OnEnable(){
			tcon.SetTimerController(this);
		}
	
		void start(){
		
		}

		void Update(){
			TimerDisplay();
		}

		public void TimerDisplay(){
			guiText.text =  tcon.SetTime();
		}
		public float TimeReset(){
			return tcon.TimeReset();
		}
		public float GetTime(){
			return tcon.GetTime();
		}
		public float ReduceTime(){
			
			return tcon.ReduceTime();
		}
	}
}