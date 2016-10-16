using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SongObject : MonoBehaviour {

	public Song song = new Song();
	public Text Title; 
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void SetTitle(string lTitle)
	{
		Title.text = lTitle;
	}
	public void SetPosition(float x, float y, float z)
	{
		Vector3 vec = Vector3.zero;
		vec.x = Title.rectTransform.sizeDelta.x/2+x;
		vec.y = y;
		vec.z = Title.rectTransform.position.z;
		Title.rectTransform.position = vec;
		//Title.rectTransform.position = vec;
	}
}
