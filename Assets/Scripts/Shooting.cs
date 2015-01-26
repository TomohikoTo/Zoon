using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	static int BULLET_MAX = 10;		//キューの要領
	int QUEUE_EMPTY = -1;		//キューの空
	int[] queue = new int[BULLET_MAX]; //キューの要素数
	int queue_first = 0;	//キューの先頭
	int queue_last = 0;		//キューの末尾
	public GameObject Shoot;
	public Transform ShootSpawn;
	public float InitialCT = 1.0f;
	public float CoolTime = 1.0f;
	public int CountPressShoot = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		shoot();
	
	}

	//弾を撃つメソッド
	public void shoot(){
		CheckCT();
		if(Input.GetMouseButtonDown(0)){


			enqueue(CountPressShoot);
		}

	}


	//待機時間を確認
	public void CheckCT(){
		//待機時間が初期状態なら実行
		if(CoolTime == InitialCT ){
			if(CountPressShoot > 0){
			//Instantiate(Shoot, ShootSpawn.position, ShootSpawn.rotation); // 弾丸を生成
				CountPressShoot--;
			dequeue();
			
			ReduceCT ();
			}
		}
		else if( 0.0 < CoolTime && CoolTime < InitialCT)
		{ 
			ReduceCT ();

		}
		else if( CoolTime <= 0.0)
		{
			ResetCT();
		}
	}


	//待機時間を減少する
	public void ReduceCT(){
		CoolTime -= Time.deltaTime;
	}

	//待機時間を初期化
	public void ResetCT(){

		CoolTime = InitialCT;
	}

	//キューにデータを追加する
	public void enqueue(int val){

		if( (queue_last + 1) %BULLET_MAX == queue_first)
		{
			/* 現在配列の中身は，すべてキューの要素で埋まっている */
			Debug.Log("ジョブが満杯です");
		}
		else
		{
			CountPressShoot++;
			/* キューに新しい値を入れる */
			queue[queue_last]=val;
			/* queue_lastを1つ後ろにずらす。
  			もし，いちばん後ろの場合は，先頭にもってくる */
			queue_last=(queue_last+1)%BULLET_MAX;
		}
	}
	
	//キューのデータを取り出す
	public int dequeue(){
		
		int queue_return;
		
		if(queue_first == queue_last)
		{
			Debug.Log("弾が空です");
			return QUEUE_EMPTY;
		}
		else
		{
			queue_return = queue[queue_first];
			
			queue_first = (queue_first + 1)%BULLET_MAX;
			Instantiate(Shoot, ShootSpawn.position, ShootSpawn.rotation); // 弾丸を生成

			return queue_return;
		}
	}

}
