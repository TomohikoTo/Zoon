using UnityEngine;
using System.Collections;

namespace zoon{
public class MouseState : MonoBehaviour , IMouseController , IPlayerState     {
		public float speed = 0.5f;
	public MouseController mcon;
	private PlayerStateManager manager;
	GameObject player;
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
		player = GameObject.Find("Player");
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
			transform.rotation = Quaternion.Slerp(mcon.GetRotation (), mcon.GetRotation(), Time.time * speed);
			
		
		return 0;
	}
}
}
