using UnityEngine;
using System.Collections;

public class LoadAttacks : MonoBehaviour {

	public string[] attacks;
	// Use this for initialization
	void Start () {
		attacks = new string[]
		{"Melee","Magic","Special"};
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		foreach (string attack in attacks)
		{
			if (GUILayout.Button(attack))
			{
				switch (attack)
				{
					case "Melee":
						Debug.Log("Melee");
						break;
					case "Magic":
						Debug.Log("Magic");
						break;
					case "Special":
						Debug.Log ("Special");
						break;
				}
			}
		}
		if(GUILayout.Button("Close"))
		{
			GameObject menu = GameObject.FindGameObjectWithTag("AttackMenu").gameObject;
			GameObject.Destroy(menu);
		}
	}
}
