using UnityEngine;
using System.Collections;

public class EnemyController : EnemyAdvancedFSM 
{
	private PlayerStateManager psmanager;
	private int health;
	
	//NPC FSMの初期化
	protected override void Initialize()
	{

		health = 100;
		
		elapsedTime = 0.0f;
		
		GameObject objPlayer = GameObject.FindGameObjectWithTag("Player");
		playerTransform = objPlayer.transform;
		
		if (!playerTransform)
			print("プレーヤーが存在しません。タグ 'Player'　を追加してください。");
		

		// FSMを構築
		ConstructFSM();
	}
	
	protected override void FSMUpdate()
	{
		//　ヘルスチェック
		elapsedTime += Time.deltaTime;
	}
	
	protected override void FSMFixedUpdate()
	{
		CurrentState.Reason(playerTransform, transform);
		CurrentState.Act(playerTransform, transform);
	}
	
	public void SetTransition(Transition t) 
	{ 
		PerformTransition(t); 
	}
	
	private void ConstructFSM()
	{
		//ポイントのリスト
		pointList = GameObject.FindGameObjectsWithTag("PatrolPoint");
		
		Transform[] waypoints = new Transform[pointList.Length];
		int i = 0;
		foreach(GameObject obj in pointList)
		{
			waypoints[i] = obj.transform;
			i++;
		}
		
		PatrolMode patrol = new PatrolMode(waypoints);
		patrol.AddTransition(Transition.SawPlayer, FSMStateID.Chasing);
		patrol.AddTransition(Transition.NoHealth, FSMStateID.Dead);
		
		ChaseMode chase = new ChaseMode(waypoints);
		chase.AddTransition(Transition.LostPlayer, FSMStateID.Patrolling);
		chase.AddTransition(Transition.ReachPlayer, FSMStateID.Attacking);
		chase.AddTransition(Transition.NoHealth, FSMStateID.Dead);

		AttackMode attack = new AttackMode(waypoints);
		attack.AddTransition(Transition.LostPlayer, FSMStateID.Patrolling);
		attack.AddTransition(Transition.SawPlayer, FSMStateID.Chasing);
		attack.AddTransition(Transition.NoHealth, FSMStateID.Dead);
		
		DeadMode dead = new DeadMode();
		dead.AddTransition(Transition.NoHealth, FSMStateID.Dead);
		
		AddFSMState(patrol);
		AddFSMState(chase);
		AddFSMState(attack);
		AddFSMState(dead);
	}
	
	//　
	void OnCollisionEnter(Collision collision)
	{
		//hpを減少させます
		if ( !psmanager.landing && collision.gameObject.tag == "Player")
		{
			Destroy(gameObject, 1.5f);
		}
	}
	
	protected void Explode()
	{
		float rndX = Random.Range(10.0f, 30.0f);
		float rndZ = Random.Range(10.0f, 30.0f);
		for (int i = 0; i < 3; i++)
		{
			rigidbody.AddExplosionForce(10000.0f, transform.position - new Vector3(rndX, 10.0f, rndZ), 40.0f, 10.0f);
			rigidbody.velocity = transform.TransformDirection(new Vector3(rndX, 20.0f, rndZ));
		}
		
		Destroy(gameObject, 1.5f);
	}
	

}