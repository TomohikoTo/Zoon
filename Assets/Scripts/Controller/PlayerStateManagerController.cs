using UnityEngine;
using System;


[Serializable]
public class PlayerStateManagerController {

	public IPlayerStateManagerController ipsmcon;
	//ゲームの状態を保持
	public PlayerStateManager psm;
	public PlayerStateManagerController() {
		psm = new PlayerStateManager();
		
	}
	
	public void SetPlayerStateManagerController(IPlayerStateManagerController ipsmcon){
		this.ipsmcon = ipsmcon;
	}
	public string GetStateName(){
		string statename = psm.activeState.ToString() ;
		return statename;
	}
}
