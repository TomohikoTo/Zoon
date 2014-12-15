﻿using UnityEngine;
using System.Collections;

namespace zoon {
public class MenuState : IState { 
	// GameStateManagerのインスタンスを再利用
	private GameStateManager manager;
	private PlayerStateManager psm;
	public GameObject player;
	public MenuState(GameStateManager GSManager) {
		//初期化
		manager = GSManager;
		

	}
	
	
	public void StateUpdate() { 
		//更新処理
			psm	= GameObject.Find("Player").GetComponent<PlayerStateManager>();

		}
		
		public void Render() { 
			//描画等
			if(GUI.Button(new Rect(50, 50, 50, 50), "MouseStage")) {

				Application.LoadLevel("MouseStage");
				Time.timeScale = 1;
				manager.SwitchState(new PlayState(manager));  
				psm.SwitchState(new MouseState(psm));  
			}
		}
	}

}

