using UnityEngine;
using System.Collections;

public class PlayManager : MonoBehaviour {
	public GameObject KeyObject;
	public Vector3 spawnValues;
	public int CheeseCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	//読み込み
	BMSLoder BMS;
	
	//メインゲームで使用する変数
	float	fBmp;		//現在のBPM値
	float	fScrMulti;	//小節間の幅の倍率
	
	
	//初期化
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (KeyObject, spawnPosition, spawnRotation);
	}
}
