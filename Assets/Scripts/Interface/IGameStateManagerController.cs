using System;
namespace zoon {
public interface IGameStateManagerController {

	void GameStateManagerInit();
	string SwitchState(IState iState);
	string FormatState();
}
}