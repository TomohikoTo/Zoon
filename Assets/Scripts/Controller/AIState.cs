using UnityEngine;
using System.Collections;

namespace zoon {
public class AIState : MonoBehaviour , IPlayerState{
	public MouseMover mm;
	public MouseController mcon;
	Random actRandom = new Random();
	private	float DicideAct = 0;
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
			mm.
			SetRandom();
			keyJammer();
			DoAct();

	}
	
	public void CreatePlayerClone(){
	
	}

	public void SetRandom(){
		DicideAct = Random.Range(1.0f, 9.0f);
	}
	public void DoAct(){
		if( 1.0f <= DicideAct && DicideAct < 3.0f ){
				mcon.PressLeftArrow();
			} else if( 3.0f <= DicideAct && DicideAct < 5.0f ){
				mcon.PressRightArrow();
			} else if( 5.0f <= DicideAct && DicideAct < 7.0f ){
				mcon.PressUpArrow();
			} else if( 7.0f <= DicideAct && DicideAct <= 9.0f ){
				mm.OnEnable();
			}
	}
	public bool keyJammer(){
			if(Input.anyKey){
				
				return false;
				
			}
			return true;
	}

}

}