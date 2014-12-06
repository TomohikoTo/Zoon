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
			// 
			if (collision.gameObject.tag == "PlayerClone")
			{
				Object.Destroy(gameObject);
			}
			
			
			
			
			
		}
	}
	//public void GetPoint(){
//			
//	}
}
