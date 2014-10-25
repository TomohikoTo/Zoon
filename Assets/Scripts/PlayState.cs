using UnityEngine;
using System.Collections;

public class PlayState : StateInt {
	// GameStateManagerのインスタンスを再利用できるよう準備
	private GameStateManager manager;
	
	public PlayState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;
	}
	
	public void StateUpdate() { 
		//更新処理
		
	}
	
	public void Render() { 
		//描画等
		if(Input.GetKeyUp(KeyCode.Escape)) {
			Application.LoadLevel("Menu");
			Time.timeScale = 1;
			manager.SwitchState(new MenuState(manager));    
		}
	}
}