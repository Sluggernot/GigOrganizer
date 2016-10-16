using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using UnityEngine.UI;
// Linq text
public class ProjectManager : MonoBehaviour {

	List<Project> projects = new List<Project>();
	List<ProjectObject> projectO = new List<ProjectObject>();
	public SongObject sObj;
	public ProjectObject prObj;
    public GameObject ProjectContainer;
    public GameObject SelectedContainer;
	XmlSerializer serializer = new XmlSerializer(typeof(Project));
	float pixelOffset = 0.0f;
	public Canvas canvas;
//	public Button titleButton;
	// Use this for initialization
	void Start () {
		//canvas = FindObjectsOfType<Canvas>()[0];

		AddTempProjects();

		FileStream fs = new FileStream("projects.xml", FileMode.Create);
		foreach(Project p in projects)
			serializer.Serialize(fs, p);
		//PrintIt();
	}
	
	// Update is called once per frame
	void Update () {
		Input();
	}	

	void Input()
	{


	}

	public void PrintIt()
	{
		//float pos = 400;//((RectTransform)titleButton.GetComponent<RectTransform>()).position.y-100;
		foreach(Project p in projects)
		{
			ProjectObject tempProj;// = new ProjectObject();
 			tempProj = Instantiate(prObj) as ProjectObject;
			tempProj.SetTitle(p.Title);
			//tempProj.SetPosition(15, pos, tempProj.gameObject.transform.position.z);
			tempProj.proj = p;
			//tempProj.transform.SetParent(canvas.transform);
            tempProj.transform.SetParent( ProjectContainer.transform );
            tempProj.transform.localScale = Vector3.one;
			projectO.Add(tempProj);
			//pos-=30;
			foreach(Song s in p.Songs)
			{
				SongObject tempSong;// = new SongObject();
				tempSong = Instantiate(sObj) as SongObject;
				tempSong.SetTitle(s.Name);
				//tempSong.SetPosition(30, pos, sObj.transform.position.z);
				//tempSong.transform.SetParent(canvas.transform);
                tempSong.transform.SetParent( tempProj.transform );
                tempSong.transform.localScale = Vector3.one;
				
				//pos-=30;
				tempProj.songO.Add(tempSong);
			}
		}
	}

	public void ProjectSelected(ProjectObject pIn)
	{
		Debug.Log("A button was pressed");
		foreach(ProjectObject p in projectO)
		{
            if ( p == pIn )
            {
                p.transform.SetParent( SelectedContainer.transform );
                p.transform.localScale = Vector3.one;
            }
            /*if(p != pIn)
            {
                p.SetPosition(-300,p.transform.position.y, p.transform.position.z);
                foreach(SongObject s in p.songO)
                {
                    s.SetPosition(-300,sObj.transform.position.y, sObj.transform.position.z);
                }
            }*/
        }

	}

	void AddTempProjects()
	{
		Project temp = new Project();
		Song song = new Song();
		Contact contact = new Contact();
		CalendarEvent eventT = new CalendarEvent();

		contact.Name = "Ben";
		contact.Number = "5129236363";
		contact.Email = "ben.miles@gmail.com";

		song.bDepth = BitDepth.Sixteen;
		song.sRate = SampleRate.FortyFour;
		song.Name = "Generic Song";
		song.Summary = "This song was really shitty.  The engineering on it was shit.";

		eventT.Date = 121314;
		eventT.Description = "This event will change my life";

		temp.Title = "This is the title of the Project";
		temp.Summary = "This sums up the project";
		temp.AlbumTitle = "Smell Like Octagenarian Spirit";
		temp.Producer = "Rudy Bega";
		temp.Engineer = "Vine Ls";

		temp.AddSong(song);
		temp.AddEvent(eventT);
		temp.AddContact(contact);

		projects.Add(temp);

		Project temp2 = new Project();
		Song song2 = new Song();

		temp2.Title = "Different Title";
		temp2.Summary = "This sums up the project";
		temp2.AlbumTitle = "Smell Like Octagenarian Spirit";
		temp2.Producer = "Rudy Bega";
		temp2.Engineer = "Vine Ls";

		song2.bDepth = BitDepth.Sixteen;
		song2.sRate = SampleRate.FortyFour;
		song2.Name = "Different Song Name";
		song2.Summary = "This song was really shitty.  The engineering on it was shit.";
		temp2.AddSong(song);
		temp2.AddSong(song2);
		projects.Add(temp2);

	}
}
