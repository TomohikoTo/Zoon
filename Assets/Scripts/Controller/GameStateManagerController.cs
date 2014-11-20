using UnityEngine;
using System;


[Serializable]
public class GameStateManagerController  {


	public IGameStateManagerController igsmcon;
	//ゲームの状態を保持
	public GameStateManager gsm;
	public GameStateManagerController() {
		gsm = new GameStateManager();
		
	}
	public void SetGameStateManagerController(IGameStateManagerController igsmcont){
		this.igsmcon = igsmcont;
	}
	public string GetStateName(){
		string statename = gsm.activeState.ToString() ;
		return statename;
	}
	
}