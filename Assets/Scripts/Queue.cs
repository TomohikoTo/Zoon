using UnityEngine;
using System.Collections;

public class Queue  : MonoBehaviour {

	static int QUEUE_MAX = 5;		//キューの要領
	int QUEUE_EMPTY = -1;		//キューの空
	int[] queue = new int[QUEUE_MAX]; //キューの要素数
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
	public int dequeue(){

		int queue_return;

		if(queue_first == queue_last)
		{
			return QUEUE_EMPTY;
		}
		else
		{
			queue_return = queue[queue_first];

			queue_first = (queue_first + 1)%QUEUE_MAX;

			return queue_return;
		}
	}
	




}
