using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour {

	public enum BattleStates
	{
		LISTEN,
		CHOOSEATTACK,
		SELECTTARGET,
		ATTACKING,
		ENEMYATTACK,
		LOSE,
		WIN
	}

	private BattleStates currentState;

	// Use this for initialization
	void Start () {
		setCurrentState("LISTEN");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (currentState);
		switch(currentState)
		{
			case (BattleStates.LISTEN):
					break;
			case (BattleStates.CHOOSEATTACK):
					break;
			case (BattleStates.SELECTTARGET):
					break;
			case (BattleStates.ATTACKING):
					break;
			case (BattleStates.ENEMYATTACK):
					break;
			case (BattleStates.LOSE):
					break;
			case (BattleStates.WIN):
					break;
		}
	}
	public void setCurrentState(string stateName)
	{
		switch(stateName)
		{
		case "LISTEN":
			{
				currentState = BattleStates.LISTEN;
				break;
			}
		case "CHOOSEATTACK":
			{
				currentState = BattleStates.CHOOSEATTACK;
				break;
			}
		case "SELECTTARGET":
			{
				currentState = BattleStates.SELECTTARGET;
				break;
			}
		case "ATTACKING":
			{
				currentState = BattleStates.ATTACKING;
				break;
			}
		case "ENEMYATTACK":
			{
				currentState = BattleStates.ENEMYATTACK;
				break;
			}
		case "LOSE":
			{
				currentState = BattleStates.LOSE;
				break;
			}
		case "WIN":
			{
				currentState = BattleStates.WIN;
				break;
			}
		}
	}
	public string getCurrentState()
	{
		string current_state = currentState.ToString();
		return current_state;
	}
}
