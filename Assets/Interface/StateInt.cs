using UnityEngine;
using System.Collections;

public interface StateInt 
{
	// UnityのUpdate()メソッドが呼び出します。
	void StateUpdate();
	
	// 描画に使います。
	void Render();
}
