using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon.Test
{
	[TestFixture]
	[Category ("CameraMover Test")]
	public class CameraMoverTest
	{
		public ICameraMoverController imover;
		public CameraMoverController mover;
		
		[SetUp] public void Init()
		{
			this.imover = GetEffectMock ();
			this.mover = GetControllerMock (imover);
		}
		
		[TearDown] public void Cleanup()
		{
		}
		[Test]
		[Category ("Mover Test Click Q")]
		public void ClickQTest() {
			mover.IsClickedQ ().Returns (true);
			mover.CalcAngle ();
			Assert.That (-5.0f, Is.EqualTo (mover.GetY()));
		}
		[Test]
		[Category ("Mover Test Click E")]
		public void ClickETest() {
			mover.IsClickedE ().Returns (true);
			mover.CalcAngle ();
			Assert.That (5.0f, Is.EqualTo (mover.GetY()));
		}
		[Test]
		[Category ("Mover Test Click F")]
		public void ClickFTest() {
			mover.IsClickedF ().Returns (true);
			mover.CalcAngle ();
			Assert.That (5.0f, Is.EqualTo (mover.GetX()));
		}

		[Test]
		[Category ("Mover Test Click R")]
		public void ClickRTest() {
			mover.IsClickedR ().Returns (true);
			mover.CalcAngle ();
			Assert.That (-5.0f, Is.EqualTo (mover.GetX()));
		}


		private ICameraMoverController GetEffectMock () {
			return Substitute.For<ICameraMoverController> ();
		}
		private CameraMoverController GetControllerMock(ICameraMoverController imover) {
			var mover = Substitute.For<CameraMoverController> ();
			imover.CameraRotation ().Returns (0);
			mover.SetCameraMoverController (imover);
			return mover;
		}
	}
}