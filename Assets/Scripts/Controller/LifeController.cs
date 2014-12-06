using System;
namespace zoon {
	[Serializable]
	public class LifeController  {
		
		private float Life = 3.0f;
		public ILifeController ilcon;
		public LifeController(){
			
		}
		public void SetLifeController(ILifeController ilcon) {
			this.ilcon = ilcon;
		}
		// Use this for initialization
		void Start () {
			
			Life = 3.0f;
			
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		//ポイント獲得
		public void AddLife(float LifePoint){
			Life += LifePoint;
		}
		
		//ポイント減少
		public void ReduceScore(float LifePoint){
			Life += LifePoint;
		}
		
		public float GetLife(){
			return Life;
		}
		public string SetLife () {
			AddLife(Life);
			return this.Life.ToString();
		}
		
	}
}
