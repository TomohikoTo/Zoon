using UnityEngine;
using System.Collections;

namespace zoon {

	public class Block : MonoBehaviour {

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}
		private void OnCollisionEnter(Collision collision)
		{
			// プレイヤーが触れたら壊れる
			if (collision.gameObject.tag == "Player")
			{

				Destroy(gameObject);
			}

		}
	}

}