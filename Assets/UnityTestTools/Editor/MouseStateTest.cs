using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon{
[TestFixture]
[Category ("MouseState Test")]
public class MouseStateTest {

	public IMouseController imcon;
	public MouseController mcon;
	
	[SetUp] public void Init()
	{
		this.imcon = GetEffectMock ();
		this.mcon = GetControllerMock (imcon);
	}
	
	[TearDown] public void Cleanup()
	{
	}
	[Test]
	[Category ("Mover Test Click LeftArrow")]
	public void ClickLeftArrowTest() {
		mcon.PressLeftArrow ().Returns (true);
		mcon.MouseMove ();
		Assert.That (-0.5f, Is.EqualTo (mcon.GetX()));
	}
	[Test]
	[Category ("Mover Test Click RightArrow")]
	public void ClickRightArrowTest() {
		mcon.PressRightArrow ().Returns (true);
		mcon.MouseMove ();
		Assert.That (0.5f, Is.EqualTo (mcon.GetX()));
	}
	
	[Test]
	[Category ("Mover Test Click UpArrow")]
	public void ClickUpArrowTest() {
		mcon.PressUpArrow ().Returns (true);
		mcon.MouseMove ();
		Assert.That (0.5f, Is.EqualTo (mcon.GetZ()));
	}
	[Test]
	[Category ("Mover Test Click DownArrow")]
	public void ClickDownArrowTest() {
		mcon.PressDownArrow ().Returns (true);
		mcon.MouseMove ();
		Assert.That (-0.5f, Is.EqualTo (mcon.GetZ()));
	}
	[Test]
	[Category ("NineDownArrow")]
	public void NineTest() {
		mcon.PressUpArrow ().Returns (true);
		mcon.PressRightArrow ().Returns (true);
		mcon.MouseMove ();
		Assert.That (45f, Is.EqualTo (mcon.GetY()));
	}

	private IMouseController GetEffectMock () {
		return Substitute.For<IMouseController> ();
	}
	private MouseController GetControllerMock(IMouseController imcon) {
		var mcon = Substitute.For<MouseController> ();
		imcon.MouseTranslation ().Returns (0);
		imcon.MouseRotation ().Returns (0);
		mcon.SetMouseController (imcon);
		return mcon;
	}
	
	
	
	

}
}
