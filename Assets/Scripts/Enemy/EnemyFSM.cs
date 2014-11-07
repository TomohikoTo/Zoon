using UnityEngine;
using System.Collections;

public class EnemyFSM : MonoBehaviour 
{
	protected Transform playerTransform;
	
	//NPCの次の到達点
	protected Vector3 destPos;

	protected float elapsedTime;
	//策敵する地点のリスト
	protected GameObject[] pointList;

	
	protected virtual void Initialize() { }
	protected virtual void FSMUpdate() { }
	protected virtual void FSMFixedUpdate() { }
	
	// Use this for initialization
	void Start () 
	{
		Initialize();
	}
	
	// Update is called once per frame
	void Update () 
	{
		FSMUpdate();
	}
	
	void FixedUpdate()
	{
		FSMFixedUpdate();
	}    
}

