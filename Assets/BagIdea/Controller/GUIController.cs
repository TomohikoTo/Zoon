using UnityEngine;
using System;

namespace zoon {
	
	[Serializable]
	public class GUIController
	{
		
		public IGUIController guiController;
		
		public GUIController (){
		}
		
		public void SetGUIController(IGUIController guiController) {
			this.guiController = guiController;
		}

		//public string setAnimateText(string animateText) {
		//	this.animateText = animateText;
		//}

	}
	
	
}
