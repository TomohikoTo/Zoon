using UnityEngine;
using System.Collections;

namespace zoon {
public class ResultState : IState {

	// GameStateManagerのインスタンスを再利用
	private GameStateManager manager;
	private PlayData pd;
	public ResultState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;
		pd = GameObject.Find ("PlayData").GetComponent<PlayData>();

	}
	
	public void StateUpdate() { 
		//更新処理
	}
	
	public void Render() { 
		//描画等
		if(GUI.Button(new Rect(50, 50, 100, 50), "メニューへ")) {
			pd.PlayReset();
			Application.LoadLevel("Menu");
			Time.timeScale = 1;
			manager.SwitchState(new MenuState(manager));
		} else if(GUI.Button(new Rect(50, 110, 100, 50), "リトライ")) {
			pd.PlayReset();
			Application.LoadLevel("MouseStage");
			Time.timeScale = 1;
			manager.SwitchState(new PlayState(manager));

		}
	}
	

}
}