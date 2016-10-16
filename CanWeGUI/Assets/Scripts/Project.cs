using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;


[System.Serializable]
public class Contact{
	public string Name {get; set;}
	public string Number {get; set;}
	public string Email {get; set;}
}

public enum BitDepth{ Sixteen, TwentyFour};
public enum SampleRate{ FortyFour, FourtyEight, NinetySix};

[System.Serializable]
public class Song{
	public string Name {get; set;}
	public string Summary {get; set;}
	public BitDepth bDepth {get; set;}
	public SampleRate sRate {get; set;}
}

[System.Serializable]
public class CalendarEvent{
	public string Description {get; set;}
	public int Date {get; set;}

}
	
[System.Serializable]
public class Project {

	public string Title {get; set;}
	public string Summary {get; set;}
	public string AlbumTitle {get; set;}
	public string Producer {get; set;}
	public string Engineer {get; set;}
	public List<CalendarEvent> 	Events{get; set;}// = new List<Event>();
	public List<Song> 			Songs{get; set;}// = new List<Song>();
	public List<Contact> 		Contacts{get; set;}// = new List<Contact>();
	
	public void AddEvent(CalendarEvent inEvent){ 	Events.Add(inEvent); }
	public void AddSong(Song inSong){ 				Songs.Add(inSong); }
	public void AddContact(Contact inContact){ 		Contacts.Add(inContact); }

	public Project(){ 
		Events = new List<CalendarEvent>();
		Songs = new List<Song>();
		Contacts = new List<Contact>();
	}
}
