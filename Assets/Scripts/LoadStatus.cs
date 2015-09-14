using UnityEngine;
using System.Collections;

public class LoadStatus : MonoBehaviour {

	public string Status = "Status";

	public void LoadScene()
	{
		Application.LoadLevel(Status);
	}
}
