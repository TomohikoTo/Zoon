using UnityEngine;
using System.Collections;

public interface IState 
{
	// Update()メソッド呼び出し
	
	void StateUpdate();
	
	// 描画。
	void Render();
}

