using UnityEngine;
using System.Collections;

public interface StateInt 
{
	// Update()メソッド呼び出si.

	void StateUpdate();
	
	// 描画。
	void Render();
}
