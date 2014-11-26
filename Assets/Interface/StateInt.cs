using UnityEngine;
using System.Collections;

namespace zoon {

public interface StateInt 
{
	// Update()メソッド呼び出し

	void StateUpdate();
	
	// 描画。
	void Render();
}

}