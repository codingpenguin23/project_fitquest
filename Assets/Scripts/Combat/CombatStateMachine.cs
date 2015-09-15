using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleStates currentState;

	// Use this for initialization
	void Start () {
		//currentState = BattelStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(currentState);
		switch(currentState)
		{
			case (BattleStates.START):
					break;
			case (BattleStates.PLAYERCHOICE):
					break;
			case (BattleStates.ENEMYCHOICE):
					break;
			case (BattleStates.LOSE):
					break;
			case (BattleStates.WIN):
					break;
		}
	}
}
