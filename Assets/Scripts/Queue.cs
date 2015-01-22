using UnityEngine;
using System.Collections;

public class Queue  {

	int QUEUE_MAX = 5;
	int QUEUE_MIN = -1;
	int queue_first = 0;	//キューの先頭
	int queue_last = 0;		//キューの末尾

	//キューにデータを追加する
	public void enqueue(){

		if( (queue_last + 1) %QUEUE_MAX == queue_first)
		{

		}
		else
		{

		}
	}

	//キューのデータを取り出す
	public void dequeue(){
	}
	

}
