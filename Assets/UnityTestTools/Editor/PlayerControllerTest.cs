using NUnit.Framework;
using System;
using NSubstitute;
[TestFixture]
[Category ("Player Test")]
public class PlayerControllerTest  {
	
	public IntPlayerController ipcon;
	public PlayerController pcon;
	
	[SetUp] public void Init()
	{
		this.ipcon = GetEffectMock ();
		this.pcon = GetControllerMock (ipcon);
	}
	
	[TearDown] public void Cleanup()
	{
	}
	[Test]
	[Category ("Mover Test Click LeftArrow")]
	public void ClickLeftArrowTest() {
		pcon.PressLeftArrow ().Returns (true);
		pcon.PlayerMove ();
		Assert.That (-0.1f, Is.EqualTo (pcon.GetX()));
	}
	[Test]
	[Category ("Mover Test Click RightArrow")]
	public void ClickRightArrowTest() {
		pcon.PressRightArrow ().Returns (true);
		pcon.PlayerMove ();
		Assert.That (0.1f, Is.EqualTo (pcon.GetX()));
	}
	
	[Test]
	[Category ("Mover Test Click UpArrow")]
	public void ClickUpArrowTest() {
		pcon.PressUpArrow ().Returns (true);
		pcon.PlayerMove ();
		Assert.That (0.1f, Is.EqualTo (pcon.GetZ()));
	}
	[Test]
	[Category ("Mover Test Click DownArrow")]
	public void ClickDownArrowTest() {
		pcon.PressDownArrow ().Returns (true);
		pcon.PlayerMove ();
		Assert.That (-0.1f, Is.EqualTo (pcon.GetZ()));
	}
	
	[Test]
	[Category ("Mover Test Click W")]
	public void ClickWTest() {
		pcon.PressW ().Returns (true);
		pcon.HumanSkill ();
		Assert.That (10f, Is.EqualTo (pcon.GetY()));
	}
	
	[Test]
	[Category ("Mover Test Click D")]
	public void ClickDTest() {
		pcon.PressD ().Returns (true);
		pcon.HumanSkill ();
		Assert.That (0.2f, Is.EqualTo (pcon.GetSpeed()));
	}
	private IntPlayerController GetEffectMock () {
		return Substitute.For<IntPlayerController> ();
	}
	private PlayerController GetControllerMock(IntPlayerController ipcon) {
		var pcon = Substitute.For<PlayerController> ();
		ipcon.PlayerTranslation ().Returns (0);
		pcon.SetPlayerController (ipcon);
		return pcon;
	}

	
	
	
	
	
}
