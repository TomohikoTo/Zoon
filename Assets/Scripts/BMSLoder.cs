using UnityEngine;
using System.Collections;

public class BMSLoder : MonoBehaviour {

	bool ok = true;				//テスト用変数
	string    lPlayer;                // プレイモード
	string    mGenre;            // データのジャンル
	string    mTitle;            // データのタイトル
	string    mArtist;           // データの製作者
	string    fBpm;                   // データのテンポ（初期値は130）
	string    mMidifile;         // バックグラウンドで流すMIDIファイル
	string    lPlaylevel;             // データの難易度
	string    lLank;                  // データの判定ランク
	string    lWavVol;                // 音量を元の何％にするか
	string    lTotal;                 // ゲージの増量を設定
	string    mStagePic; 
	string	  mWav;		//wavデータ
	string	  mBmp;		//bmpファイル
	string player;
	string genre;
	int comNum;
	// コマンドの番号を返す
	int GetCommand( string s )
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
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetHeader(  );
		
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
					comNum = GetCommand(bmsTxt);
					switch(comNum){
						
					case 0: // PLAYER
						lPlayer = bmsTxt ;
						Debug.Log (lPlayer);
						break;
						
					case 1: // GENRE
						mGenre = bmsTxt ;
						Debug.Log (mGenre);
						break;
						
					case 2: // TITLE
						mTitle = bmsTxt ;
						Debug.Log (mTitle);
						break;
						
					case 3: // ARTIST
						mArtist = bmsTxt ;
						Debug.Log (mArtist);
						break;
						
					case 4: // BPM
						fBpm = bmsTxt ;
						Debug.Log (fBpm);
						break;
						
					case 5: // MIDIFILE
						mMidifile = bmsTxt ;
						Debug.Log (mMidifile);
						break;
						
					case 6: // PLAYLEVEL
						lPlaylevel = bmsTxt ;
						Debug.Log (lPlaylevel);
						break;
						
					case 7: // RANK
						lLank = bmsTxt ;
						Debug.Log (lLank);
						break;
						
					case 8: // VOLWAV
						lWavVol = bmsTxt ;
						Debug.Log (lWavVol);
						break;
						
					case 9: // TOTAL
						lTotal = bmsTxt ;
						Debug.Log (lTotal);
						break;
						
					case 10: // StageFile
						mStagePic = bmsTxt ;
						Debug.Log (mStagePic);
						break;
						
					case 11: // WAV
						mGenre = bmsTxt ;
						Debug.Log (mGenre);
						break;
						
					case 12: // BMP
						mWav = bmsTxt ;
						Debug.Log (mWav);
						break;
						
					case 13: // GENRE
						mBmp = bmsTxt ;
						Debug.Log (mBmp);
						break;
					}
					
					
				}
			}
			
		}
		ok = false;
		// cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
		bmsf.Close();
		
		// 結果を表示する
	}
	
	
	public void LoadBmsData( )
	{
		// StreamReader の新しいインスタンスを生成する
		System.IO.StreamReader bmsf = (
			new System.IO.StreamReader(@"test.bms", System.Text.Encoding.Default)
			);
		
		char data;     // パラメータ部分の文字列のコピー用
		int com;             // コマンド番号
		char num;         // 数字変換汎用バッファ
		int lines;           // 小節番号
		int channel;         // チャンネル番号
		int length;          // 文字列の長さ
		int hex;             // １６進を１０進に変換した値
		int tick;            // １音符の長さ
		
	}
}
