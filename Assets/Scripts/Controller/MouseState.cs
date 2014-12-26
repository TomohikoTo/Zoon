using UnityEngine;
using System.Collections;

namespace zoon{
public class MouseState : MonoBehaviour  , IPlayerState     {
	public float speed = 3.0f;
	private PlayerStateManager manager;
	public GameObject mouse;
	public GameObject player;
	public GameObject playerClone;
	public GameStateManagerController gsmcon;

	
	public MouseState(PlayerStateManager psm) {
		//初期化
			manager = psm;

		//SpawnPoint = GameObject.FindWithTag("SpawnPoint");
		
	}
	// Use this for initialization
	void Start () {

			playerClone = GameObject.FindGameObjectWithTag("PlayerClone");


	}
	public void Render() { 
		}
	public void StateUpdate(){

			if(mouse == null) {

					Object.Destroy(playerClone);
		
				CreatePlayerClone();
			} else {
				
				
			}


	}
	// Update is called once per frame
	
	
	//マウスを生成
	public void CreatePlayerClone()
		{
			player = GameObject.FindGameObjectWithTag("Player");
			playerClone = GameObject.FindGameObjectWithTag("PlayerClone");
			mouse = (GameObject) Instantiate(Resources.Load("Player/mouse"), new Vector3(0, 0, 0), Quaternion.identity);
			mouse.transform.parent = player.transform;
		}
	
	
}
}
