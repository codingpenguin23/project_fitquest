using UnityEngine;
using System.Collections;

public class LoadCombat : MonoBehaviour {

	public string Combat = "Combat";

	public void LoadScene()
	{
		var LastLevel = Application.loadedLevel;
		Application.LoadLevel(Combat);
	}
}
