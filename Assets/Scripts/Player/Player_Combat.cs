using UnityEngine;
using System.Collections;

public class Player_Combat : MonoBehaviour {

//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}
	public int currentState;

	public int CombatState(int currentState)
	{
		this.currentState = currentState;
		return this.currentState;
	}
}
