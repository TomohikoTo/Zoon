using System;

public interface IGameStateManagerController {

	void GameStateManagerInit();
	string SwitchState(IState iState);
	string FormatState();
}
