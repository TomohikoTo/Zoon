using NUnit.Framework;
using System;
using NSubstitute;
[TestFixture]
[Category ("Player Test")]
public class PlayerControllerTest  {
	
	public IntPlayerController ipcont;
	public PlayerController pcont;
	
	[SetUp] public void Init()
	{
		this.ipcont = GetEffectMock ();
		this.pcont = GetControllerMock (ipcont);
	}
	
	[TearDown] public void Cleanup()
	{
	}
	[Test]
	[Category ("Mover Test Click LeftArrow")]
	public void ClickLeftArrowTest() {
		pcont.PressLeftArrow ().Returns (true);
		pcont.PlayerMove ();
		Assert.That (-0.1f, Is.EqualTo (pcont.GetX()));
	}
	[Test]
	[Category ("Mover Test Click RightArrow")]
	public void ClickRightArrowTest() {
		pcont.PressRightArrow ().Returns (true);
		pcont.PlayerMove ();
		Assert.That (0.1f, Is.EqualTo (pcont.GetX()));
	}
	
	[Test]
	[Category ("Mover Test Click UpArrow")]
	public void ClickUpArrowTest() {
		pcont.PressUpArrow ().Returns (true);
		pcont.PlayerMove ();
		Assert.That (0.1f, Is.EqualTo (pcont.GetZ()));
	}
	[Test]
	[Category ("Mover Test Click DownArrow")]
	public void ClickDownArrowTest() {
		pcont.PressDownArrow ().Returns (true);
		pcont.PlayerMove ();
		Assert.That (-0.1f, Is.EqualTo (pcont.GetZ()));
	}
	
	[Test]
	[Category ("Mover Test Click W")]
	public void ClickWTest() {
		pcont.PressW ().Returns (true);
		pcont.HumanSkill ();
		Assert.That (1000f, Is.EqualTo (pcont.GetY()));
	}
	
	[Test]
	[Category ("Mover Test Click D")]
	public void ClickDTest() {
		pcont.PressD ().Returns (true);
		pcont.HumanSkill ();
		Assert.That (0.2f, Is.EqualTo (pcont.GetSpeed()));
	}
	private IntPlayerController GetEffectMock () {
		return Substitute.For<IntPlayerController> ();
	}
	private PlayerController GetControllerMock(IntPlayerController ipcont) {
		var pcont = Substitute.For<PlayerController> ();
		ipcont.PlayerTranslation ().Returns (0);
		pcont.SetPlayerController (ipcont);
		return pcont;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	
	
	
	
}
