using UnityEngine;
using System.Collections;

namespace zoon {
public class AIState : MonoBehaviour , IPlayerState{


		public AIState(PlayerStateManager PSManager) {
			//初期化

			
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	public void StateUpdate(){
			keyJammer();

	}
	
	public void CreatePlayerClone(){
	
	}

	public bool keyJammer(){
			if(Input.anyKey){
				
				return false;
				
			}
			return true;
	}
}

}