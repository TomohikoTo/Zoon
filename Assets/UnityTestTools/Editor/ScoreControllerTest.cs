using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon {
	[TestFixture]
	[Category ("Player Test")]
	public class ScoreControllerTest {

		public IScoreController iscon;
		public ScoreController scon;
		public ScoreDisplayer sd;
		[SetUp] public void Init()
		{
			this.iscon = GetEffectMock();
			this.scon = GetControllerMock (iscon);
		}
		[TearDown] public void Cleanup()
		{
			
		}

		[Test]
		[Category ("Test")]

		private IScoreController GetEffectMock () {
			return Substitute.For<IScoreController> ();
		}

		private ScoreController GetControllerMock(IScoreController iscon){
			var scon = Substitute.For <ScoreController>();
			scon.SetScoreController(iscon);
			return scon;
		}
	}
}