using System;
namespace zoon {
public interface IPlayerStateManagerController {
	
	void PlayerStateManagerInit();
	string SwitchState(IPlayerState ipState);
	string FormatState();
}

}