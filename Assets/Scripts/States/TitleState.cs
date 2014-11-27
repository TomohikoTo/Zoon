using UnityEngine;
using System.Collections;


namespace zoon {
	public class TitleState : IState {
		public Texture2D titleTexture;
		private GameStateManager manager;
		
		public TitleState(GameStateManager GSManager) {
			//初期化
			manager = GSManager;
			Time.timeScale = 0;
		}
		
		public void StateUpdate() {

					//更新処理
			if(Input.anyKey) { // 何らかのキーを押すとMenuStateに遷移

				
				manager.SwitchState(new MenuState(manager));
				Application.LoadLevel("Menu");
			}
		}

		public void Render() {
			//描画等

		}



}
}