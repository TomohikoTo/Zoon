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
			Assert.That ("zoon.MouseState", Is.EqualTo (activeState));
		}

		[Test]
		[Category ("SwitchHumanState")]
		public void SwitchHumanStateTest() {
			string activeState = psmcon.psm.SwitchState( new HumanState(this.psm));
			Assert.That ("zoon.HumanState", Is.EqualTo (activeState));
		}

		[Test]
		[Category ("SwitchBirdState")]
		public void SwitchBirdStateTest() {
			string activeState = psmcon.psm.SwitchState( new BirdState(this.psm));
			Assert.That ("zoon.BirdState", Is.EqualTo (activeState));
		}

		[Test]
		[Category ("SwitchAIState")]
		public void SwitchAIStateTest() {
			string activeState = psmcon.psm.SwitchState( new AIState(this.psm));
			Assert.That ("zoon.AIState", Is.EqualTo (activeState));
		}
		[Test]
		[Category ("SwitchMouseState")]
		public void  PluraSwitchStateTest() {
			string activeState = psmcon.psm.SwitchState( new MouseState(this.psm));
			activeState = psmcon.psm.SwitchState( new BirdState(this.psm));
			activeState = psmcon.psm.SwitchState( new HumanState(this.psm));
			activeState = psmcon.psm.SwitchState( new BirdState(this.psm));
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
