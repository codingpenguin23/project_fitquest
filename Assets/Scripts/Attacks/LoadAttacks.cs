using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LoadAttacks : MonoBehaviour {

	public List<Attacks> loadedAttacks = new List<Attacks>();
	public int[] damage;
	//public GameObject avatar = GameObject.Find("Player").gameObject;
	public Animator p_animator;
	public Animator e_animator;
	// Use this for initialization
	void Start () {
		loadAttacks();
		p_animator = GameObject.Find("Player").gameObject.GetComponent<Animator>();
		e_animator = GameObject.Find("Enemy").gameObject.GetComponent<Animator>();
//		foreach (string attack in attacks)
//		{
//			GameObject attackButton = Resources.Load<GameObject>("AttackButton");
//			GameObject button = GameObject.Instantiate(attackButton) as GameObject;
//			txt = button.GetComponent<Text>();
//			txt.text = attack;
//
//			GameObject AttackMenu = GameObject.FindGameObjectWithTag("AttackMenu");
//			button.transform.SetParent(AttackMenu.transform,false);
//		}
//		if(GUILayout.Button("Close"))
//		{
//			GameObject menu = GameObject.FindGameObjectWithTag("AttackMenu").gameObject;
//			GameObject.Destroy(menu);
//		}
//	}
	
	// Update is called once per frame
	}
	void Update () 
		{
	
		}
	void OnGUI ()
	{
		GameObject menu = GameObject.FindGameObjectWithTag("AttackMenu").gameObject;

		foreach (Attacks a in loadedAttacks)
		{
			if (GUILayout.Button(a.getAttackName(), GUILayout.Width(300),GUILayout.Height(100)))
					{
						switch (a.getAttackName())
						{
							case "Melee":
								GameObject.Destroy (menu);
								p_animator.Play("Attack");
								e_animator.Play("Die");
								break;
							case "Magic":
								Debug.Log(a.getAttackName());
								Debug.Log(a.getAttackDamage());
								break;
							case "Special":
								Debug.Log(a.getAttackName());
								Debug.Log(a.getAttackDamage());
								break;
				}
				GameObject mainCanvas = GameObject.FindGameObjectWithTag("MainCanvas").gameObject;
					mainCanvas.GetComponent<CombatStateMachine>().setCurrentState("SELECTTARGET");

					}
		}
		if(GUILayout.Button("Close",GUILayout.Width(300),GUILayout.Height(100)))
		{
			GameObject.Destroy(menu);
		}
	}
	void loadAttacks()
	{
		//All attack values are base levels, modifiers will be applied later.
		Attacks melee = new Attacks("Melee",20,10);
		loadedAttacks.Add(melee);
		Attacks magic = new Attacks("Magic",50,20);
		loadedAttacks.Add(magic);
		Attacks special = new Attacks("Special",100,50);
		loadedAttacks.Add(special);
	}
}
