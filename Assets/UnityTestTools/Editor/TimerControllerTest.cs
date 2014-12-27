using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon {
	[TestFixture]
	[Category ("Player Test")]
	public class TimerControllerTest  {

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
		[Category ("Test")]
		
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