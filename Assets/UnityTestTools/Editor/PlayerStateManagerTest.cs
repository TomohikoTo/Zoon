using NUnit.Framework;
using System;
using NSubstitute;
namespace zoon {
[TestFixture]
[Category ("Player Test")]
	public class PlayerStateManagerTest  {

		public IPlayerStateManagerController ipsmcon;
		public PlayerStateManagerController	psmcon;
		public PlayerStateManager psm;

		[SetUp] public void Init()
		{
			this.ipsmcon = GetEffectMock ();
			this.psmcon = GetControllerMock (ipsmcon);
		
		}

		[TearDown] public void Cleanup()
		{

		}

		[Test]
		[Category ("SwitchMouseState")]
		public void SwitchMouseStateTest() {
			string activeState = psmcon.psm.SwitchState( new MouseState(this.psm));
			Assert.That ("MouseState", Is.EqualTo (activeState));
		}
		private IPlayerStateManagerController GetEffectMock () {
			return Substitute.For<IPlayerStateManagerController> ();
		}

		private PlayerStateManagerController GetControllerMock(IPlayerStateManagerController ipsmcon) {
			var psmcon = Substitute.For<PlayerStateManagerController> ();
			psmcon.SetPlayerStateManagerController(ipsmcon);
			return psmcon;
		}

	}
}
