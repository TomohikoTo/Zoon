using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace zoon{
public class BMSData : MonoBehaviour {
	int ind;		//":"のIndex取得用変数
	public int[] _data;					// パラメータ部分の文字列のコピー
	public int[] Data
	{
		get{ return this._data; }
		set{ this._data = value;}
	}

	private int _lines;    				// 小節番号
	public int Lines
	{
		get{ return this._lines; }
		set{ this._lines = value;}
	}

	private int _channel;			    // チャンネル番号
	public int Channel
	{
		get{ return this._channel; }
		set{ this._channel = value;}
	}

	private int _length;          		// 文字列の長さ
	public int Length
	{
		get{ return this._length; }
		set{ this._length = value;}
	}

	private int _hex;		            // １６進を１０進に変換した値
	public int Hex
	{
		get{ return this._hex; }
		set{ this._hex = value;}
	}
	private int _tick;            		// １音符の長さ
	public int Tick
	{
		get{ return this._tick; }
		set{ this._tick = value;}
	}
	long changeLines; 	//小節の長さを定義倍用の値

	private List<int> _dataList  = new List<int>();	//パラメータ部分の配列
	public List<int> DataList
	{
		get{ return _dataList;}
		set{ _dataList = value;}
	}
	//PlayManagerで使用するための臨時BMSデータ
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
}
