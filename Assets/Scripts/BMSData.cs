using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BMSData : MonoBehaviour {
	int ind;		//":"のIndex取得用変数
	public int[] data;		// パラメータ部分の文字列のコピー用
	int lines;           // 小節番号
	int channel;         // チャンネル番号
	int length;          // 文字列の長さ
	int hex;             // １６進を１０進に変換した値
	int tick;            // １音符の長さ
	long changeLines; 	//小節の長さを定義倍用の値
	public List<int> dataList  = new List<int>();
	
	//PlayManagerで使用するための臨時BMSデータ
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
