﻿using UnityEngine;
using System.Collections;

public class DeadMode : EnemyFSMState
{
	public DeadMode() 
	{
		stateID = FSMStateID.Dead;
	}
	
	public override void Reason(Transform player, Transform npc)
	{
		
	}
	
	public override void Act(Transform player, Transform npc)
	{
		
	}
}