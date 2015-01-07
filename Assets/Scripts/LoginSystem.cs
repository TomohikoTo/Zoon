using UnityEngine;
using System.Collections;

public class LoginSystem : MonoBehaviour {

	public string id;
	public string pw;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LoginMenu(){

		//テキストボックス
		int txW = 200, txH = 20;
		id = GUI.TextField (new Rect(Screen.width*1/2, Screen.height*1/2, txW , twH), id);
		pw = GUI.TextField (new Rect(Screen.width*1/2, Screen.heigjt*1/2, txW , twH), pw);
		

		}
}
