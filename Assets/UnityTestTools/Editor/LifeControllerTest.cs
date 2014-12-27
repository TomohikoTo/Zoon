using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon {
	[TestFixture]
	[Category ("Player Test")]
	public class LifeControllerTest {
		private float LifePoint = 1f; 
		private string word;
		public ILifeController ilcon;
		public LifeController lcon;
		public LifeDisplayer ld;
		[SetUp] public void Init()
		{
			this.ilcon = GetEffectMock();
			this.lcon = GetControllerMock (ilcon);
		}
		[TearDown] public void Cleanup()
		{
			
		}
		
		[Test]
		[Category ("InitializeCheckTest")]
		public void InitializeCheckTest() {
			
			Assert.That (3f, Is.EqualTo (lcon.GetLife() ));
		}
		[Test]
		[Category ("ErrorCheckTest")]
		public void ReduceScoreErrorCheckTest() {
			//点数がマイナスにならないかどうかのテスト
			lcon.AddLife(LifePoint);
			for( int i = 0; i < 100 ; i++)
			{
				lcon.ReduceLife(LifePoint);
			}
			Assert.That (0f, Is.EqualTo (lcon.GetLife() ));
		}
		
		[Test]
		[Category ("ErrorCheckTest")]
		public void AddErrorCheckTest() {
			//点数が上限を超えて異常な値になるかどうかのテスト
			LifePoint = 9999999999f;
			for( int i = 0; i < 5000 ; i++)
			{
				lcon.AddLife(LifePoint);
			}
			Assert.That (0f, Is.EqualTo (lcon.GetLife() ));
		}
		
		
		[Test]
		[Category ("ScoreResetTest")]
		public void ScoreResetTest() {
			//点数が上限を超えて異常な値になるかどうかのテスト
			
			lcon.AddLife(LifePoint);
			lcon.ResetLife();
			Assert.That (3f, Is.EqualTo (lcon.GetLife() ));
		}
		[Test]
		[Category ("FieldTest")]
		public void StringCheckTest() {
			//点数がstring型かどうかのテスト
			word = "0";
			
			
			Assert.That (word, Is.EqualTo (lcon.SetLife() ));
		}
		private ILifeController GetEffectMock () {
			return Substitute.For<ILifeController> ();
		}
		
		private LifeController GetControllerMock(ILifeController ilcon){
			var lcon = Substitute.For <LifeController>();
			lcon.SetLifeController(ilcon);
			return lcon;
		}
	}
}