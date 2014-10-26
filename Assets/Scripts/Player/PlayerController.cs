using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour {
	private GameObject Boy_anim;
	private Animator animator;
	private int WalkId;
	public bool Jump = false;
	public float JumpSpeed = 50.0f;
		public float BaseSpeed = 0.5f;
	public float MoveSpeed = 0.5f;
	public float DashSpeed = 2.0f;
	public float MaxSpeed = 4.0f;
	public float MinSpeed = 0.0f;
	[HideInInspector]
	public float PlayerSpeed;
	// Use this for initialization
	void Start () {
		PlayerSpeed = BaseSpeed;
		}
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.RightControl) && MaxSpeed > MoveSpeed){
			MoveSpeed *= DashSpeed;
		} else if(Input.GetKeyUp(KeyCode.RightControl)){
			MoveSpeed = BaseSpeed;
		}

		//transform.Translate(Vector3.forward * PlayerSpeed * 0.01f);
		//x軸移動
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(-MoveSpeed,0.0f,0.0f);
			/*if( transform.rotation.y != 45){
				transform.Rotate(0.0f,2f,0.0f);
			} else if(transform.rotation.y == 90){
			}
			*/
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(MoveSpeed,0.0f,0.0f);
		}
		//ピッチ運動
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(0.0f,0.0f,MoveSpeed);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(0.0f,0.0f,-MoveSpeed);
		}
		if(Input.GetKey(KeyCode.Space)){
			Destroy.Boy_anim;
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