using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
	public class ProjectList : MonoBehaviour
	{
		public GameObject ProjectPrefab;

		public Transform ProjectContainer;
		
		List<Project> projects = new List<Project>();

		private void Awake()
		{
			AddTempProjects();
		}

		private void Start()
		{
			foreach (Project proj in projects)
			{
				GameObject currentProject = Instantiate(ProjectPrefab);
				currentProject.transform.SetParent(ProjectContainer);
				currentProject.transform.localScale = Vector3.one;

				currentProject.GetComponent<ProjectListItem>().TitleText.text = proj.Title;
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

		public void AddNewProject()
		{
			PanelSwapperSingleton.Instance.swapPanels(Panels.NEW_PROJECT_VIEW);
		}
	}
}
