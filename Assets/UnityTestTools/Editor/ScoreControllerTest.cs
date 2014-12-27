using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon {
	[TestFixture]
	[Category ("Player Test")]
	public class ScoreControllerTest {
		private string word;
		public float ScorePoint = 10f;
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
		[Category ("InitializeCheckTest")]
		public void InitializeCheckTest() {

			Assert.That (0f, Is.EqualTo (scon.GetScore() ));
		}
		[Test]
		[Category ("ErrorCheckTest")]
		public void ReduceScoreErrorCheckTest() {
			//点数がマイナスにならないかどうかのテスト
			scon.AddScore(ScorePoint);
			for( int i = 0; i < 100 ; i++)
			{
				scon.ReduceScore(ScorePoint);
			}
			Assert.That (0f, Is.EqualTo (scon.GetScore() ));
		}

		[Test]
		[Category ("ErrorCheckTest")]
		public void AddErrorCheckTest() {
			//点数が上限を超えて異常な値になるかどうかのテスト
			ScorePoint = 9999999999f;
			for( int i = 0; i < 5000 ; i++)
			{
				scon.AddScore(ScorePoint);
			}
			Assert.That (0f, Is.EqualTo (scon.GetScore() ));
		}


		[Test]
		[Category ("ScoreResetTest")]
		public void ScoreResetTest() {
			//点数が上限を超えて異常な値になるかどうかのテスト

				scon.AddScore(ScorePoint);
			scon.ResetScore();
			Assert.That (0f, Is.EqualTo (scon.GetScore() ));
		}
		[Test]
		[Category ("FieldTest")]
		public void StringCheckTest() {
			//点数がstring型かどうかのテスト
			word = "0";

			
			Assert.That (word, Is.EqualTo (scon.SetScore() ));
		}
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