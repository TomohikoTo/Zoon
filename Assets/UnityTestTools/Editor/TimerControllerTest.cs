using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon {
	[TestFixture]
	[Category ("Player Test")]
	public class TimerControllerTest  {
		private string word;
		public ITimerController itcon;
		public TimerController tcon;
		public TimerDisplayer td;
		[SetUp] public void Init()
		{
			this.itcon = GetEffectMock();
			this.tcon = GetControllerMock (itcon);
		}
		[TearDown] public void Cleanup()
		{
			
		}
		
		[Test]
		[Category ("InitializeCheckTest")]
		public void InitializeCheckTest() {
			
			Assert.That (0f, Is.EqualTo (tcon.GetTime() ));
		}
		[Test]
		[Category ("ErrorCheckTest")]
		public void ReduceTimeErrorCheckTest() {
			//点数がマイナスにならないかどうかのテスト

			for( int i = 0; i < 100 ; i++)
			{
				tcon.ReduceTime();
			}
			Assert.That (0f, Is.EqualTo (tcon.GetTime() ));
		}
		
	/*	[Test]
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
		
		*/
		[Test]
		[Category ("TimeResetTest")]
		public void TimeResetTest() {
			//点数が上限を超えて異常な値になるかどうかのテスト
			

			tcon.TimeReset();
			Assert.That (30f, Is.EqualTo (tcon.GetTime() ));
		}
		[Test]
		[Category ("FieldTest")]
		public void StringCheckTest() {
			//点数がstring型かどうかのテスト
			word = "0";
			
			
			Assert.That (word, Is.EqualTo (tcon.SetTime() ));
		}
		private ITimerController GetEffectMock () {
			return Substitute.For<ITimerController> ();
		}
		
		private TimerController GetControllerMock(ITimerController itcon){
			var tcon = Substitute.For <TimerController>();
			tcon.SetTimerController(itcon);
			return tcon;
		}
	}
}