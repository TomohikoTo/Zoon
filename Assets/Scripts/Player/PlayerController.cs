using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour {
	private Animator animator;
	private int WalkId;

	public bool Jump = false;
	public float JumpSpeed = 50.0f;
		public float BaseSpeed = 5.0f;
	public float RollSpeed = 5.0f;
	public float PitchSpeed = 5.0f;
	public float MaxSpeed = 10.0f;
	public float MinSpeed = 0.0f;
	[HideInInspector]
	public float PlayerSpeed;
	// Use this for initialization
	void Start () {
		PlayerSpeed = BaseSpeed;
		}
	// Update is called once per frame
	void Update () {
		//transform.Translate(Vector3.forward * PlayerSpeed * 0.01f);
		//x軸移動
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(-BaseSpeed,0.0f,0.0f);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(BaseSpeed,0.0f,0.0f);
		}
		//ピッチ運動
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0.0f,0.0f,BaseSpeed);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(0.0f,0.0f,-BaseSpeed);
		}

		
		// ジャンプ中でないときにマウス左ボタンが押されたらジャンプする
		if (!Jump && Input.GetKey(KeyCode.W))
		{
			Jump = true;
			// オブジェクトの上方向に力を瞬間的に与える
			rigidbody.AddForce(transform.up * JumpSpeed, ForceMode.Impulse);
		}
	/*	//加減速
		if(Input.GetKey(KeyCode.Q) && (PlayerSpeed < MaxSpeed)){
			transform.Translate(0,BaseSpeed,0);
		}
		if(Input.GetKey(KeyCode.E) && (PlayerSpeed > MinSpeed)){
			transform.Translate(0,-BaseSpeed,0);
		}
	*/
	}
	private void OnCollisionEnter(Collision collision)
	{
		// 床オブジェクトと衝突したらジャンプ中ではないのでjump = falseにする
		if (collision.gameObject.tag == "Floor")
		{
			Jump = false;
		}
	}
}