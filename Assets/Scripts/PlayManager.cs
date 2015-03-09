using UnityEngine;
using System.Collections;

public class PlayManager : MonoBehaviour {
	public GameObject KeyObject;
	public Vector3 spawnValues;
	public int CheeseCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public int spawnCount;
	public float CT;
	public Transform startPoint;
	//読み込み
	BMSLoder BMS;
	BMSData  BD;
	//メインゲームで使用する変数
	float	fBmp;		//現在のBPM値
	float	fScrMulti;	//小節間の幅の倍率
	
	bool ok = true;
	//初期化
	
	// Use this for initialization
	void Start () 
	{
		
		BMS = GetComponent<BMSLoder>();
		BD = GetComponent<BMSData>();
	}
	// Update is called once per frame
	void Update () {
		
		if(ok){
			BMS.LoadBmsData();
			spawnCount = BD.dataList.Count;
		}
		
		Vector3 spawnPosition = new Vector3 ( spawnValues.x, spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		
		if( 0 < spawnCount && CT <= 0f){
			Instantiate (KeyObject, spawnPosition, spawnRotation);
			spawnCount--;
			CT = 0.6f;
			Debug.Log ("残りオブジェクト数" +spawnCount);
		}
		CT = CT - Time.deltaTime;
		
		
		ok = false;
	}
}
