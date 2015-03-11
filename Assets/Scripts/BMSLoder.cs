using UnityEngine;
using System;

public class BMSLoder : MonoBehaviour {
	
	BMSData BD;		//BMSデータ臨時保存用のデータスクリプ
	bool ok = true;
	struct BMSHeader{
	
		string    lPlayer{set; get;}                // プレイモード
		string    mGenre{set; get;}             // データのジャンル
		string    mTitle{set; get;}             // データのタイトル
		string    mArtist{set; get;}            // データの製作者
		string    fBpm{set; get;}                    // データのテンポ（初期値は130）
		string    mMidifile{set; get;}          // バックグラウンドで流すMIDIファイル
		string    lPlaylevel{set; get;}              // データの難易度
		string    lLank{set; get;}                   // データの判定ランク
		string    lWavVol{set; get;}                 // 音量を元の何％にするか
		string    lTotal{set; get;}                  // ゲージの増量を設定
		string    mStagePic{set; get;}  
		string	  mWav{set; get;} 		//wavデータ
		string	  mBmp{set; get;} 		//bmpファイル
		string player{set; get;} ;
		string genre{set; get;} ;
	}
	
	string dataTxt;
	int ind;		//":"のIndex取得用変数
	public int[] data;     // パラメータ部分の文字列のコピー用
	int lines;           // 小節番号
	int channel;         // チャンネル番号
	int length;          // 文字列の長さ
	int hex;             // １６進を１０進に変換した値
	int tick;            // １音符の長さ
	long changeLines; 	//小節の長さを定義倍用の値
	int comNum;
	
	// Use this for initialization
	void Start () {
		BD = GetComponent<BMSData>();
	}
	
	// Update is called once per frame
	void Update () {
		/*	GetHeader(  );
		LoadBmsData( );
		ok = false;
	*/	
	}
	// コマンドの番号を返す
	int GetHeadCommand( string s )
	{
		
		//	com[1] = "GENRE\0".ToCharArray();
		string[] command = {
			"PLAYER",
			"GENRE",
			"TITLE",
			"ARTIST",
			"BPM",
			"MIDIFILE",
			"PLAYLEVEL",
			"RANK",
			"VOLWAV",
			"TOTAL",
			"STAGEFILE",
			"WAV",
			"BMP",
		};
		
		
		// 検索ルーチン
		int i;
		for(i=0;i<13;i++) {
			if( 0 <= s.IndexOf(command[i])) {
				
				return i;       // コマンドならその番号を返す
			}
		}
		
		// オブジェ配置なら -1
		return -1;
	}
	string SetHeadCommand(string s){
		
		int ind = s.IndexOf("#");
		
		return	s.Substring(ind + 1);
		
	}
	
	
	//ヘッダ情報の読み取り処理
	public void GetHeader(  ){
		// StreamReader の新しいインスタンスを生成する
		System.IO.StreamReader bmsf = (
			new System.IO.StreamReader(@"test.bms", System.Text.Encoding.Default)
			);
		
		
		if( ok ){
			// 読み込みできる文字がなくなるまで繰り返す
			while (bmsf.Peek() >= 0) {
				// ファイルを 1 行ずつ読み込む
				string bmsTxt = bmsf.ReadLine();
				
				// 読み込んだものを追加で格納する
				
				if( bmsTxt != ""){ 
					//char[] chTxt = stBuffer.ToCharArray();
					comNum = GetHeadCommand(bmsTxt);
					string it;
					it = SetHeadCommand(bmsTxt);
					switch(comNum){
						
					case 0: // PLAYER
						lPlayer = it ;
						Debug.Log (lPlayer);
						break;
						
					case 1: // GENRE
						mGenre = it ;
						Debug.Log (mGenre);
						break;
						
					case 2: // TITLE
						mTitle = it ;
						Debug.Log (mTitle);
						break;
						
					case 3: // ARTIST
						mArtist = it ;
						Debug.Log (mArtist);
						break;
						
					case 4: // BPM
						fBpm = it ;
						Debug.Log (fBpm);
						break;
						
					case 5: // MIDIFILE
						mMidifile = it ;
						Debug.Log (mMidifile);
						break;
						
					case 6: // PLAYLEVEL
						lPlaylevel = it ;
						Debug.Log (lPlaylevel);
						break;
						
					case 7: // RANK
						lLank = it ;
						Debug.Log (lLank);
						break;
						
					case 8: // VOLWAV
						lWavVol = it ;
						Debug.Log (lWavVol);
						break;
						
					case 9: // TOTAL
						lTotal = it ;
						Debug.Log (lTotal);
						break;
						
					case 10: // StageFile
						mStagePic = it ;
						Debug.Log (mStagePic);
						break;
						
					case 11: // WAV
						mGenre = it ;
						Debug.Log (mGenre);
						break;
						
					case 12: // BMP
						mWav = it ;
						Debug.Log (mWav);
						break;
						
					case 13: // GENRE
						mBmp = it ;
						Debug.Log (mBmp);
						break;
					}
					
					
				}
			}
			
		}
		
		// cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
		bmsf.Close();
		
		// 結果を表示する
	}
	
	
	public void LoadBmsData( )
	{
		if( ok ){
			// StreamReader の新しいインスタンスを生成する
			System.IO.StreamReader bmsf = (
				new System.IO.StreamReader(@"test.bms", System.Text.Encoding.Default)
				);
			
			
			while (bmsf.Peek() >= 0) {
				string bmsTxt = bmsf.ReadLine();
				ind = bmsTxt.IndexOf(":");
				if( 0 <= ind  ){ 
					lines = int.Parse(bmsTxt.Substring(1,3));
					channel = int.Parse(bmsTxt.Substring(4,2));
					dataTxt = bmsTxt.Substring(ind + 1);
					Debug.Log(  lines + "小節目" );
					Debug.Log(channel + "チャンネル" );
					Debug.Log( dataTxt + "パラメータ");
					if( channel == 2){
						changeLines = long.Parse (dataTxt);
					}
					if( channel != 2 && dataTxt.Length%2==1) {
						bmsf.Close();
					}
					if( channel != 2 && dataTxt.Length%2== 0 )
					{
						// 実際のデータの追加
						length = dataTxt.Length / 2;
						tick = 10000 / length;
						Debug.Log("音符の長さ" + tick);
						for( int i = 0; i< length; i++)
						{
							data = new int[length];
							string hexTxt;
							hexTxt = dataTxt.Substring( i * 2,2);
							hex = Convert.ToInt32(hexTxt, 16);
							data[i] = hex;
							BD.dataList.Add(data[i]);
							Debug.Log("data" + i + "番目" +data[i]);
						}
						//data = long.Parse (dataTxt);
						Debug.Log("length" +length);
						//	Debug.Log("data" +data);
					}
					
				}
			}
			bmsf.Close();
			
		}
	}
	
	
	
	
	

}

