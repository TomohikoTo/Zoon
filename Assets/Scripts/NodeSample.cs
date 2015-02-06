using UnityEngine;
using System.Collections;
using System.Text;
public class NodeSample : MonoBehaviour {

	class Node
		
	{
		
		public int item;
		
		public Node leftc;
		
		public Node rightc;
		

		
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
			
			newNode.item = id;
			newNode.item = weight;

			if (root == null)
				
				root = newNode;
			
			else
				
			{
				
				Node current = root;
				
				Node parent;
				
				while (true)
					
				{
					
					parent = current;
					
					if (weight < current.item)
						
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
