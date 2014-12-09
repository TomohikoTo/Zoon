using UnityEngine;
using System;
namespace zoon {
	[Serializable]
public class ScoreController  {

	
	public IScoreController iscon;
	public ScoreController(){

	}
	public void SetScoreController(IScoreController iscon) {
		this.iscon = iscon;
	}
	private float score = 0.0f;
	// Use this for initialization
	void Start () {
		
		score = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//ポイント獲得
	public float AddScore(float ScorePoint){
		return score += ScorePoint;
	}
	
	//ポイント減少
	public float ReduceScore(float ScorePoint){
		return score -= ScorePoint;
	}

	public float GetScore(){
		return score;
	}
	public string SetScore () {

			return this.score.ToString();
	}
	
}
}
