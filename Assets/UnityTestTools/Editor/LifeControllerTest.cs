using NUnit.Framework;
using System;
using NSubstitute;

namespace zoon {
	[TestFixture]
	[Category ("Player Test")]
	public class LifeControllerTest {

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
		[Category ("Test")]
		
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