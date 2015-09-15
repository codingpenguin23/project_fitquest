using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Combat : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		foreach (Touch touch in Input.touches)
		{
			int pointerID = touch.fingerId;
			if (EventSystem.current.IsPointerOverGameObject(pointerID))
			{
				return;
			}
			if (touch.phase == TouchPhase.Ended)
			{return;}
		}
	}
	void OnGui()
	{
		GUI.Label(new Rect (10,10,100,200), EventSystem.current.currentSelectedGameObject.name.ToString());
		GUI.Label(new Rect (20,20,100,200), EventSystem.current.firstSelectedGameObject.name.ToString());
	}
}
