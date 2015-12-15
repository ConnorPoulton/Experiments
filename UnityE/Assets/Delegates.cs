using UnityEngine;
using System.Collections;

public class Delegates : MonoBehaviour {

	public delegate int DelegateX(int x);//Declare delegate type

	static int SquareNumber(int x) //the function we want to add to the delegate
	{
		return x * x;
	}

	static int DoubleNumber(int x) //another function to add to the delegate
	{
		return x * 2;
	}

	DelegateX squared = new DelegateX(SquareNumber); //create instance of the delegate
	DelegateX doubled = new DelegateX(DoubleNumber);

	//now we can call the functions SquareNumber and DoubleNumber by passing them as variables of type DelegateX

	void ReadDelegates(DelegateX delegatex)
	{
		Debug.Log (delegatex (4));
	}

	void Start()
	{
		ReadDelegates (squared);
	}

}
