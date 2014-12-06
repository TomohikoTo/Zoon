using UnityEngine;
using System.Collections;
namespace zoon {
	public class LifeDisplayer : MonoBehaviour , ILifeController{
		
		public GameObject Life;
		public LifeController lcon;
		
		public void OnEnable() {
			lcon.SetLifeController (this);
		}	// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			LifeDisplay();
		}
		public void LifeDisplay(){
			guiText.text =  lcon.SetLife();
			
		}
		
	}
}

