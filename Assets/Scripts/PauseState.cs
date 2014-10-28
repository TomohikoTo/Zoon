using UnityEngine;
using System.Collections;

public class PauseState : MonoBehaviour {
	public GameObject pause;
	// 初期化
	void Start () {
		pause = GameObject.Find("Pause");
		Time.timeScale = 0;
	}
	
	// 更新処理
	void Update () {
	
		if(GUI.Button(new Rect(50, 50, 50, 50), "Play")) {
			Time.timeScale = 1;
			Object.Destroy(pause);  
		}

	}
}
