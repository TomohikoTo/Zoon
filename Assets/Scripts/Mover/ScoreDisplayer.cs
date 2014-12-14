using UnityEngine;
using System.Collections;
namespace zoon {
	public class ScoreDisplayer : MonoBehaviour , IScoreController{

	public ScoreController scon;

	public void OnEnable() {
		scon.SetScoreController (this);
	}	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			ScoreDisplay();
	}
	public void ScoreDisplay(){
			guiText.text =  scon.SetScore();

	}
	public float AddScore(float ScorePoint){
			return scon.AddScore (ScorePoint);
	}
	public float ReduceScore(float ScorePoint){
			return scon.ReduceScore (ScorePoint);
	}

	
}
}