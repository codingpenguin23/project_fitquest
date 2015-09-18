using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

	public static void LoadAllInformation()
	{
		GameInformation.player_name = PlayerPrefs.GetString("PLAYERNAME");
		GameInformation.player_level = PlayerPrefs.GetInt("PLAYERLVL");
		GameInformation.player_experiencePoints = PlayerPrefs.GetInt("PLAYERXP");
		GameInformation.player_gold = PlayerPrefs.GetInt("PLAYERGOLD");
		GameInformation.player_attackPoints = PlayerPrefs.GetInt("PLAYERAP");
		GameInformation.player_health = PlayerPrefs.GetInt("PLAYERHEALTH");
		GameInformation.player_strength = PlayerPrefs.GetInt("PLAYERSTRENGTH");
	}
}
