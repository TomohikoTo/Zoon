using UnityEngine;
using System.Collections;
public class Shooting : MonoBehaviour {
	static int BULLET_MAX = 10; //キューの要領
	int BULLET_EMPTY = -1; //キューの空
	int[] bullet = new int[BULLET_MAX]; //キューの構造
	//キューの先頭
	private int bf;
	public int bullet_first
	{
		get{ return bf; }
		set{ bf = value; }
	}
	//キューの末尾
	private int bl;
	int bullet_last{
		get{ return bl; }
		set{ bl = value; }
	}

	//優先度
	public int shootWeight; 
	
	public GameObject ShootOne;
	public GameObject ShootTwo;
	public Transform ShootSpawn;
	public float InitialCT = 1.0f;
	public float CoolTime = 1.0f;
	public int CountPressShoot = 0;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		shoot();
	}
	//弾を撃つメソッド
	public void shoot(){
		CheckCT();
		if(Input.GetKeyDown(KeyCode.A)){
			shootWeight = 3;
			enqueue(CountPressShoot , shootWeight);
		}
		if(Input.GetKeyDown(KeyCode.S)){
			shootWeight = 5;
			enqueue(CountPressShoot , shootWeight);
		}
	}
	//待機時間を確認
	public void CheckCT(){
		//待機時間が初期状態なら実行
		if(CoolTime == InitialCT ){
			if(CountPressShoot > 0){
				//Instantiate(Shoot, ShootSpawn.position, ShootSpawn.rotation); // 弾丸を生成
				CountPressShoot--;
				dequeue();
				ReduceCT ();
			}
		}
		else if( 0.0 < CoolTime && CoolTime < InitialCT)
		{
			ReduceCT ();
		}
		else if( CoolTime <= 0.0)
		{
			ResetCT();
		}
	}
	//待機時間を減少する
	public void ReduceCT(){
		CoolTime -= Time.deltaTime;
	}
	//待機時間を初期化
	public void ResetCT(){
		CoolTime = InitialCT;
	}
	//キューにデータを追加する
	public void enqueue(int cps, int sw){
		if( (bullet_last + 1) %BULLET_MAX == bullet_first)
		{
			/* 現在配列の中身は，すべてキューの要素で埋まっている */
			Debug.Log("Capacity Over");
		}
		else
		{
			Tree theTree = new Tree();
			CountPressShoot++;
			theTree.Insert(cps,sw);
			theTree.Inorder(theTree.ReturnRoot());
			/* キューに新しい値を入れる */
			bullet[bullet_last]=sw;
			/* queue_lastを1つ後ろにずらす。
もし，いちばん後ろの場合は，先頭にもってくる　 */
			bullet_last=(bullet_last+1)%BULLET_MAX;
		}
	}
	//キューのデータを取り出す
	public int dequeue(){
		int queue_return;
		if(bullet_first == bullet_last)
		{
			Debug.Log("Empty Bullet");
			return BULLET_EMPTY;
		}
		else
		{

			queue_return = bullet[bullet_first];
			bullet_first = (bullet_first + 1)%BULLET_MAX;
			if(queue_return == 3){
				Instantiate(ShootOne, ShootSpawn.position, ShootSpawn.rotation); // 弾丸を生成
			}
			if(queue_return == 5){
				Instantiate(ShootTwo, ShootSpawn.position, ShootSpawn.rotation); // 弾丸を生成
			}
			return queue_return;
		}
	}


	class Node
		
	{
		
		public int item;
		
		public Node leftc;
		
		public Node rightc;
		
		public void display()
			
		{
			

			Debug.Log(item);
			

			
		}
		
	}
	
	class Tree
		
	{
		
		public Node root;
		
		public Tree()
			
		{ 
			
			root = null; 
			
		}
		
		public Node ReturnRoot()
			
		{
			
			return root;
			
		}
		
		public void Insert(int id, int weight)
			
		{
			
			Node newNode = new Node();
			

			newNode.item = weight;
			newNode.item = id;
			if (root == null)
				
				root = newNode;
			
			else
				
			{
				
				Node current = root;		
				Node parent;	
				while (true)
					
				{
					parent = current;
					
					if (id < current.item)
						
					{
						
						current = current.leftc;
						
						if (current == null)
							
						{
							
							parent.leftc = newNode;
							
							return;
							
						}
						
					}
					
					else
						
					{
						
						current = current.rightc;
						
						if (current == null)
							
						{
							
							parent.rightc = newNode;
							
							return;
							
						}
						
					}
					
				}
				
			}
			
		}

		//
		public void Inorder(Node Root)
			
		{
			
			if (Root != null)
				
			{
				Inorder(Root.leftc);		
				Inorder(Root.rightc);

			}

		}
	}

}