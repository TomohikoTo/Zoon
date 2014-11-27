using UnityEngine;
using System.Collections;
namespace zoon {
public class ClickButton : MonoBehaviour {

	public float incX = 3;
	public float incY = 3;
	
	void OnMouseDown()
	{
		Rect tmp = gameObject.guiTexture.pixelInset;
		tmp.x += incX;
		tmp.y -= incY;
		gameObject.guiTexture.pixelInset = tmp;
		
		Debug.Log("clicked button : " + gameObject.name);
	}
	
	void OnMouseUp()
	{
		Rect tmp = gameObject.guiTexture.pixelInset;
		tmp.x -= incX;
		tmp.y += incY;
		gameObject.guiTexture.pixelInset = tmp;
	}

	void OnMouseEnter() {
	
		print("カーソルが乗っています！");


	}

	void OnMouseExit() {
		print("カーソルが離れてます！");
	}
}
}
