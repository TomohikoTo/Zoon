using UnityEngine;
using System.Collections;

public class NodeSample : MonoBehaviour {

	class Node
		
	{
		
		public int item;
		
		public Node leftc;
		
		public Node rightc;
		
		public void display()
			
		{
			
			Console.Write("[");
			
			Console.Write(item);
			
			Console.Write("]");
			
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
		
		public void Insert(int id)
			
		{
			
			Node newNode = new Node();
			
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
}
