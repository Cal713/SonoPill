using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonClickTest : MonoBehaviour {
	public Button MapButton;

	// Use this for initialization
	void Start () 
	{
		Button btn = MapButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}
	
	void TaskOnClick()
	{
		Debug.Log ("Button Clicked");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
