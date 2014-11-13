using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class ResultState : StateInt {

	// GameStateManagerのインスタンスを再利用
	private GameStateManager manager;

	public ResultState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;

	}
	
	public void StateUpdate() { 
		//更新処理
	}
	
	public void Render() { 
		//描画等
		if(GUI.Button(new Rect(50, 50, 100, 50), "メニューへ")) {
			Application.LoadLevel("Menu");
			Time.timeScale = 1;
			manager.SwitchState(new MenuState(manager));
		} else if(GUI.Button(new Rect(50, 110, 100, 50), "リトライ")) {

			Application.LoadLevel("TestScene");
			Time.timeScale = 1;
			manager.SwitchState(new PlayState(manager));
=======
namespace zoon {

	public class ResultState : StateInt {
		GameObject player;
		// GameStateManagerのインスタンスを再利用
		private GameStateManager manager;
		
		public ResultState(GameStateManager GSManager) {
			//初期化
			manager = GSManager;
			player = GameObject.Find("Player");
			Object.Destroy(player);
		}
		
		public void StateUpdate() { 
			//更新処理
			
		}
		
		public void Render() { 
			//描画等
			if(GUI.Button(new Rect(50, 50, 100, 50), "メニューへ")) {
				Application.LoadLevel("Menu");
				Time.timeScale = 1;
				manager.SwitchState(new MenuState(manager));
			} else if(GUI.Button(new Rect(50, 110, 100, 50), "リトライ")) {
				Application.LoadLevel("TestScene");
				Time.timeScale = 1;
				manager.SwitchState(new PlayState(manager));
			}
>>>>>>> TB
		}
	}

}