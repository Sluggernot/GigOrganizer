using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System.Collections.Generic;


public class ProjectObject : MonoBehaviour {

	public Text Title; 
//	public Button button;
	public ProjectManager pMan;
	public Project proj = new Project();
	public List<SongObject> songO = new List<SongObject>();
	// Use this for initialization
	void Start () {
		pMan = FindObjectsOfType<ProjectManager>()[0];
//		Debug.Log(pMan.name);
        GetComponentInChildren<Button>().onClick.AddListener( () => ButtonPressed() );
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ButtonPressed()
	{
		Debug.Log("At least the PojectObject thinks the button was pressed");
		pMan.ProjectSelected(this);
	}

	public void SetTitle(string lTitle)
	{
		Title.text = lTitle;
		
	}
	public void SetPosition(float x, float y, float z)
	{
		Vector3 vec = Vector3.zero;
		vec.x = ((RectTransform)GetComponent<RectTransform>()).sizeDelta.x/2+x;//Title.rectTransform.position.x;
		vec.y = y;
		vec.z = Title.rectTransform.position.z;
		((RectTransform)GetComponent<RectTransform>()).position = vec;
    }
}
