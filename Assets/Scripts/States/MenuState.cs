using UnityEngine;
using System.Collections;

namespace zoon {
public class MenuState : IState { 
	// GameStateManagerのインスタンスを再利用
	private GameStateManager manager;
	private PlayerStateManager psm;
	public GameObject playerClone;
	public TimerDisplayer td;
	public GameObject player;
		//初期化
	public MenuState(GameStateManager GSManager) {
		
		manager = GSManager;
		
		

	}
	
		//更新処理

	public void StateUpdate() { 
		
			DestroyPlayer();
			psm	= GameObject.Find("Player").GetComponent<PlayerStateManager>();
			td	= GameObject.Find ("Timer").GetComponent<TimerDisplayer>();
		}

		//描画等
		public void Render() { 

			//マウスステージに移動するボタン
			if(GUI.Button(new Rect(50, 50, 50, 50), "MouseStage")) {
				SwitchMouseStage();
			}
		}
			
		//プレイヤーのオブジェクトを破棄
		public void DestroyPlayer(){
				//プレイヤーの子オブジェクトがあるなら、プレイ画面で重複しないよう破棄する処理
				playerClone = GameObject.FindGameObjectWithTag("PlayerClone");
				if( playerClone != null)
				Object.Destroy(playerClone);

		}


		//マウスステージに遷移
		public void SwitchMouseStage(){
			td.TimeReset();;
			Application.LoadLevel("MouseStage");
			Time.timeScale = 1;
			manager.SwitchState(new PlayState(manager));  
			psm.SwitchState(new MouseState(psm));
		}

	}


}

