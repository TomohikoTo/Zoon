using UnityEngine;
using System.Collections;

public class ScoreData : MonoBehaviour {

	private float score = 0.0f;
	// Use this for initialization
	void Start () {

		score = 0.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//ポイント獲得
	public void AddScore(float ScorePoint){
		score += ScorePoint;
	}

	public float GetScore(){
		return score;
	}
	public void SetScore (float score) {
		this.score = score;
	}
}
