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
		[Category ("Mover Test")]
		public void ScoreTest() {
			mover.IsClickedF ().Returns (true);

			Assert.That ("Score :100", Is.EqualTo(text));
		}
		
		[Test]
		[Category ("Mover Range Test")]
		public void ScoreTest([Range(-4,4,1)]int x) {
			string text = mover.GetX(x);
			Assert.That ("Score :" + x.ToString(), Is.EqualTo(text));
		}
		
		[Test]
		[Category ("Score Format Test")]
		public void ScoreFormatTest() {
			string text = imover.CameraRotation ();
			Assert.That ("Score :100", Is.EqualTo(text));
		}
		
		[Test]
		[Category ("Mover Format Test")]
		public void GetGameDataTest() {
			string text = score.GetScoreText (iscore.GetGameData());
			Assert.That ("Score :100", Is.EqualTo(text));
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