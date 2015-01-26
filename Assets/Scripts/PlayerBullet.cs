using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {

	public float Speed = 100.0f;
	public float LifeTime = 1.5f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject,LifeTime);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += 
			transform.forward * Speed * Time.deltaTime;
	
	}
}
