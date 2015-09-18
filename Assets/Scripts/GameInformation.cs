using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	//Player Variables
	public static string player_name {get; set;}
	public static CharacterClass player_class {get; set;}
	public static int player_health {get; set;}
	public static int player_gold {get; set;}
	public static int player_attackPoints {get; set;}
	public static int player_experiencePoints {get; set;}
	public static int player_strength {get; set;}
	public static int player_level {get; set;}

	//EnemyVariables
	public static int currentEnemyHealth {get; set;}
	public static int currentEnemyArmor {get; set;}
	public static int currentEnemyStrength {get; set;}
	public static int currentEnemyLevel {get; set;}
	public static int currentEnemyGold {get; set;}



	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(this);
	}
}
