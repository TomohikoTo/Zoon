using NUnit.Framework;
using System;
using NSubstitute;
[TestFixture]
[Category ("Player Test")]
public class GameStateManagerTest{

	public IGameStateManagerController igsmcon;
	public GameStateManagerController gsmcon;
	[SetUp] public void Init()
	{
		this.igsmcon = GetEffectMock ();
		this.gsmcon = GetControllerMock (igsmcon);
	}
	
	[TearDown] public void Cleanup()
	{
	}
	[Test]
	[Category ("SwitchTitleState")]
	public void SwitchTitleStateTest() {
	
	}
	[Test]
	[Category ("SwitchMenuState")]
	public void SwitchMenuStateTest() {
		
	}
	[Test]
	[Category ("SwitchPlayState")]
	public void SwitchPlayStateTest() {
		
	}
	[Test]
	[Category ("SwitchResultState")]
	public void SwitchResultStateTest() {
		
	}

	private IGameStateManagerController GetEffectMock () {
		return Substitute.For<IGameStateManagerController> ();
	}
	private GameStateManagerController GetControllerMock(IGameStateManagerController igsmcon) {
		var gsmcon = Substitute.For<GameStateManagerController> ();
		gsmcon.SetGameStateManagerController(igsmcon);
		return gsmcon;
	}
}
