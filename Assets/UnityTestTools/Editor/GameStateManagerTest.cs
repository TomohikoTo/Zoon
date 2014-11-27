using NUnit.Framework;
using System;
using NSubstitute;
namespace zoon.Test {
[TestFixture]
[Category ("Player Test")]
public class GameStateManagerTest{

	public IGameStateManagerController igsmcon;
	public GameStateManagerController gsmcon;
	public GameStateManager gsm;
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
		string activeState = gsmcon.gsm.SwitchState( new TitleState(this.gsm));
		Assert.That ("TitleState", Is.EqualTo (activeState));
	}
	[Test]
	[Category ("SwitchMenuState")]
	public void SwitchMenuStateTest() {
		string activeState = gsmcon.gsm.SwitchState( new MenuState(this.gsm));
		Assert.That ("MenuState", Is.EqualTo (activeState));
	}
	[Test]
	[Category ("SwitchPlayState")]
	public void SwitchPlayStateTest() {
		string activeState = gsmcon.gsm.SwitchState( new PlayState(this.gsm));
		Assert.That ("PlayState", Is.EqualTo (activeState));
	}
	[Test]
	[Category ("SwitchResultState")]
	public void SwitchResultStateTest() {
		string activeState = gsmcon.gsm.SwitchState( new ResultState(this.gsm));
		Assert.That ("ResultState", Is.EqualTo (activeState));
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
}
