using UnityEngine;
using System.Collections;

public class MouseState : MonoBehaviour , IPlayerState, IMouseController    {

	public MouseController mcon;
	private PlayerStateManager manager;
	GameObject player;
	public void OnEnable() {
		mcon.SetMouseController (this);
	}
	
	public MouseState(PlayerStateManager psm) {
		//初期化
		manager = psm;
		//player = GameObject.Find("Player");
		//SpawnPoint = GameObject.FindWithTag("SpawnPoint");
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void StateUpdate () {
	
		mcon.MouseMove();
		MouseTranslation ();
		MouseRotation ();
	}
	public int MouseTranslation() {
		
		this.transform.position = (mcon.GetPosition ());
		
		return 0;
	}

	public int MouseRotation() {
		
		this.transform.rotation = Quaternion.Euler (mcon.GetRotation ());
		
		return 0;
	}
}
