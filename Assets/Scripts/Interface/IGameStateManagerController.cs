using System;

public interface IGameStateManager {

	void GameStateManagerInit();
	string SwichState(IState istate);
	string FormatState();
}
