using UnityEngine;
using System;

namespace zoon {
	
	[Serializable]
	public class GUIController
	{

		private string animateText;
		
		public IGUIController guiController;
		
		public GUIController (){
		}
		
		public void SetGUIController(IGUIController guiController) {
			this.guiController = guiController;
		}

		public string getAnimateText() {
			return this.animateText;
		}

		//public string setAnimateText(string animateText) {
		//	this.animateText = animateText;
		//}

	}
	
	
}
