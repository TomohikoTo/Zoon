using UnityEngine;
using System.Collections;
namespace zoon{
public class GetCheese : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void OnCollisionEnter(Collision collision)
	{
			// 床オブジェクトと衝突したらジャンプ中ではないのでjump = falseにする
			if (collision.gameObject.tag == "Player")
			{
				Object.Destroy(gameObject);
			}
			
			
			
			
			
		}
	}
}
