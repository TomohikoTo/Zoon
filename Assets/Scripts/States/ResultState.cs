using UnityEngine;
using System.Collections;

namespace zoon {
public class ResultState : IState {

	// GameStateManagerのインスタンスを再利用
	private GameStateManager manager;
	private PlayData pd;

	//初期化処理
	public ResultState(GameStateManager GSManager) {
		
		manager = GSManager;
		//プレイデータ初期化処理用にコンポーネントを探す
		pd = GameObject.Find ("PlayData").GetComponent<PlayData>();

	}
	//更新処理
	public void StateUpdate() { 
		
	}
	//描画等
	public void Render() { 
		
		if(GUI.Button(new Rect(50, 50, 100, 50), "メニューへ")) {
			
		} else if(GUI.Button(new Rect(50, 110, 100, 50), "リトライ")) {
				SwitchResult();

		}
	}
	
	//メニュー画面に遷移
	public void SwitchMenu(){
			pd.PlayReset();
			Application.LoadLevel("Menu");
			Time.timeScale = 1;
			manager.SwitchState(new MenuState(manager));
	}
	//リザルト画面に遷移
	public void SwitchResult(){
			pd.PlayReset();
			Application.LoadLevel("MouseStage");
			Time.timeScale = 1;
			manager.SwitchState(new PlayState(manager));

	}
}
}