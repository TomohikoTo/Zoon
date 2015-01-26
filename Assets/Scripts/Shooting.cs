using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {


	public float InitialCT = 1.0f;
	public float CoolTime = 1.0f;
	public float CountPressShoot = 0.0f;
	public Queue queue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//弾を撃つメソッド
	public void shoot(){

		if(Input.GetKey(KeyCode.S)){
			CountPressShoot++;
			CheckCT();
		}

	}


	//待機時間を確認
	public void CheckCT(){
		//待機時間が初期状態なら実行
		if(CoolTime == InitialCT){
			
			CountPressShoot--;
			queue.dequeue ();
		}
		//待機時間を減らしす
		else if( 0.0 < CoolTime && CoolTime < InitialCT)
		{ 
			ReduceCT ();
			SleepShoot();
		}
		//待機時間が0秒以下になったら待機時間を初期化
		else if( CoolTime <= 0.0)
		{
			ResetCT();
		}
	}
	//待機時間の時にメッセージを表示
	public void SleepShoot(){

		Debug.Log(CoolTime + "秒お待ちください");
	}

	//待機時間を減少する
	public void ReduceCT(){
		CoolTime -= Time.deltaTime;
	}

	//待機時間を初期化
	public void ResetCT(){

		CoolTime = InitialCT;
	}



}
