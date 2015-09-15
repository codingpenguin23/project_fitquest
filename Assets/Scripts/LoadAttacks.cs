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
				switch ()
					case attacks[0]:
						break;
			}
		}
	}
}
