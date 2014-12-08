using UnityEngine;
using System.Collections;
namespace zoon{
public class GetCheese : MonoBehaviour {

		private float ScorePoint = 10f;
		ScoreDisplayer sd;
	// Use this for initialization
	void Start () {
			sd	= GameObject.Find("Score").GetComponent<ScoreDisplayer>();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void OnCollisionEnter(Collision collision)
	{
			// プレイヤーがチーズに接触したら消滅
			if (collision.gameObject.tag == "PlayerClone")
			{
				sd.AddScore(ScorePoint);
				Object.Destroy(gameObject);
			}
			
			
			
			
			
		}
	}
	//public void GetPoint(){
//			
//	}
}
