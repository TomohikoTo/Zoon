using UnityEngine;
using System.Collections;


public class MenuState : StateInt { 
	// GameStateManagerのインスタンスを再利用
	private GameStateManager manager;
	public GameObject player;
	public MenuState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;


	}
	
	public void StateUpdate() { 
		//更新処理


		}
		
		public void Render() { 
			//描画等
			if(GUI.Button(new Rect(50, 50, 50, 50), "Play")) {
				Application.LoadLevel("TestScene");
				Time.timeScale = 1;
				manager.SwitchState(new PlayState(manager));    
			}
		}
	}



