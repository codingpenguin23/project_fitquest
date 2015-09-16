using UnityEngine;
using System.Collections;

public class AttackMenu : MonoBehaviour {

	// Use this for initialization
	public void LoadAttackMenu () {
		GameObject attack_Menu = Resources.Load<GameObject>("AttackMenu");
		GameObject menu = GameObject.Instantiate(attack_Menu)as GameObject;
		menu.tag = "AttackMenu";
	}
	
	// Update is called once per frame
	public void Close () {
		GameObject window = this.transform.parent.gameObject;
		Destroy(window);
	}
}
