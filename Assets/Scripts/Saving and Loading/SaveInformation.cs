using UnityEngine;
using System.Collections;

public class SaveInformation : MonoBehaviour {

	public static void SaveAllInformation()
	{
		PlayerPrefs.SetString("PLAYERNAME", GameInformation.player_name);
		PlayerPrefs.SetInt("PLAYERLVL", GameInformation.player_level);
		PlayerPrefs.SetInt("PLAYERXP",GameInformation.player_experiencePoints);
		PlayerPrefs.SetInt("PLAYERAP",GameInformation.player_attackPoints);
		PlayerPrefs.SetInt("PLAYERHEALTH",GameInformation.player_health);
		PlayerPrefs.SetInt("PLAYERGOLD",GameInformation.player_gold);
		PlayerPrefs.SetInt("PLAYERSTENGTH",GameInformation.player_strength);

	}
}
