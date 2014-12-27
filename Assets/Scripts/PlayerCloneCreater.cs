using UnityEngine;
using System.Collections;
namespace zoon {
public class PlayerCloneCreater : MonoBehaviour {
	public GameObject mouse;
	public GameObject player;
	public GameObject playerClone;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	//マウスを生成
	public void CreateMouse()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		playerClone = GameObject.FindGameObjectWithTag("PlayerClone");
		mouse = (GameObject) Instantiate(Resources.Load("Player/mouse"), new Vector3(0, 0, 0), Quaternion.identity);
		mouse.transform.parent = player.transform;
	}
}
}
