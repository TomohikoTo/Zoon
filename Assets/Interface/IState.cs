using UnityEngine;
using System.Collections;
namespace zoon {
public interface IState 
{
	// Update()メソッド呼び出し
	
	void StateUpdate();
	
	// 描画。
	void Render();
}

}