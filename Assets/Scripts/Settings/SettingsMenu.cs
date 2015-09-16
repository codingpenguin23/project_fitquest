using UnityEngine;
using System.Collections;

public class SettingsMenu : MonoBehaviour {
	
	public void LoadMenu()
	{
		GameObject settings_Menu = Resources.Load<GameObject>("SettingsMenu");
		GameObject menu = GameObject.Instantiate(settings_Menu) as GameObject;
	}

	public void Close()

	{
		Destroy(this.transform.parent.gameObject);
	}

}
