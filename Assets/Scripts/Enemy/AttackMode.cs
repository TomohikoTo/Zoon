using UnityEngine;
using System.Collections;

public class AttackMode : EnemyFSMState
{
	public AttackMode(Transform[] wp) 
	{ 
		waypoints = wp;
		stateID = FSMStateID.Attacking;
		curRotSpeed = 1.0f;
		curSpeed = 100.0f;
		FindNextPoint();
	}
	
	public override void Reason(Transform player, Transform npc)
	{
		//プレーヤーとの距離を確認
		float dist = Vector3.Distance(npc.position, player.position);
		if (dist >= 200.0f && dist < 300.0f)
		{
			//ターゲット地点に回転
			Quaternion targetRotation = Quaternion.LookRotation(destPos - npc.position);
			npc.rotation = Quaternion.Slerp(npc.rotation, targetRotation, Time.deltaTime * curRotSpeed);
			
			//前進
			npc.Translate(Vector3.forward * Time.deltaTime * curSpeed);
			
			Debug.Log("Switch to Chase State");
			npc.GetComponent<EnemyController>().SetTransition(Transition.SawPlayer);
		}
		//距離が遠すぎる場合
		else if (dist >= 300.0f)
		{
			Debug.Log("Switch to Patrol State");
			npc.GetComponent<EnemyController>().SetTransition(Transition.LostPlayer);
		}  
	}
	
	public override void Act(Transform player, Transform npc)
	{
		//ターゲット地点をプレーヤーポジションに設定
		destPos = player.position;

	}
}