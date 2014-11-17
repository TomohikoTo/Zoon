using UnityEngine;
using System;


[Serializable]
public class GameStateManagerController  {


	public  IntStateManagerController ismcon;
	//ゲームの状態を保持
	public GameStateManager gsm;
	public GameStateManagerController() {
		gsm = new GameStateManager();
		
	}
	public void SetGameStateManagerController(IntStateManagerController gsmcont){
		this.ismcon = gsmcont;
	}
	public string GetStateName(){
		string statename = gsm.activeState.ToString() ;
		return statename;
	}
	
}