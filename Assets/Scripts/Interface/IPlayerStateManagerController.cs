using System;

public interface IPlayerStateManagerController {
	
	void PlayerStateManagerInit();
	string SwitchState(IPlayerState ipState);
	string FormatState();
}
