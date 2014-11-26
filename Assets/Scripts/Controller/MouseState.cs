using UnityEngine;
using System.Collections;

namespace zoon{
public class MouseState : MonoBehaviour , IMouseController , IPlayerState     {
	public float speed = 3.0f;
	public MouseController mcon;
	private PlayerStateManager manager;
	
	public void OnEnable() {
	mcon.SetMouseController(this);
	}
	
	public MouseState(PlayerStateManager psm) {
		//初期化
		manager = psm;

		//SpawnPoint = GameObject.FindWithTag("SpawnPoint");
		
	}
	// Use this for initialization
	void Start () {
		
	}
	
	public void StateUpdate(){
			Update ();

	}
	// Update is called once per frame
	public void Update () {
	
		mcon.MouseMove();
		MouseTranslation ();
		MouseRotation ();
	}
	public int MouseTranslation() {
		
		this.transform.position = (mcon.GetPosition ());
		
		return 0;
	}

	public int MouseRotation() {
			this.transform.rotation = Quaternion.Euler (mcon.GetRotation()); 
			
		
		return 0;
	}
}
}
