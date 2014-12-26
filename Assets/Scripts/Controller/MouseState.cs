using UnityEngine;
using System.Collections;

namespace zoon{
public class MouseState : IPlayerState     {
	public float speed = 3.0f;
	private PlayerStateManager manager;
	public GameObject mouse;
	public GameObject player;
	public GameObject playerClone;
	public GameStateManagerController gsmcon;
	public PlayerCloneCreater pc;
	
	public MouseState(PlayerStateManager psm) {
		//初期化
			manager = psm;

		//SpawnPoint = GameObject.FindWithTag("SpawnPoint");
		
	}
	// Use this for initialization
	void Start () {



	}
	public void Render() { 
		}
	public void StateUpdate(){
			mouse = GameObject.Find("mouse(Clone)");
			if(mouse == null) {

				Object.Destroy(playerClone);
				pc = GameObject.Find("Player").GetComponent<PlayerCloneCreater>();
				pc.CreateMouse();
			} else {
				
				
			}


	}
	// Update is called once per frame
	
	
	//マウスを生成
/*	public void CreatePlayerClone()
		{
			player = GameObject.FindGameObjectWithTag("Player");
			playerClone = GameObject.FindGameObjectWithTag("PlayerClone");
			mouse = (GameObject) Instantiate(Resources.Load("Player/mouse"), new Vector3(0, 0, 0), Quaternion.identity);
			mouse.transform.parent = player.transform;
		}
	*/
	
}
}
