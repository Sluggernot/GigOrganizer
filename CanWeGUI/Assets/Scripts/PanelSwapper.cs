using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Assets.Scripts
{
	public class PanelSwapper : MonoBehaviour
	{
		public GameObject ProjectManagementPrefab;

		public GameObject ProjectViewPrefab;

		public GameObject NewProjectView;

		private Panels previousPanel;

		private Panels currentPanel;
		

		// Main container for prefabs in which to hold the current view.
		public Transform MainContainer;

		private GameObject currentView;

		private void Awake()
		{
			SwapPanel(ProjectManagementPrefab);
		}

		private void SwapPanel(GameObject panel)
		{
			if ( currentView != null )
			{
				Destroy(currentView.gameObject);
			}
			currentView = Instantiate(panel);
			currentView.transform.SetParent(MainContainer);
			currentView.transform.localScale = Vector3.one;
		}

		public void SwapToPanel(Panels panel)
		{
			previousPanel = currentPanel;
			switch ( panel )
			{
				case Panels.PROJECT_EDIT_VIEW:
					{
						SwapPanel(ProjectViewPrefab);
						break;
					}
				case Panels.PROJECT_LIST_VIEW:
					{
						SwapPanel(ProjectManagementPrefab);
						break;
					}
				case Panels.NEW_PROJECT_VIEW:
					{
						SwapPanel(NewProjectView);
						break;
					}
			}
			currentPanel = panel;
		}

		public void GoToPreviousPanel()
		{
			if ( currentPanel != Panels.PROJECT_LIST_VIEW )
			{
				SwapToPanel(previousPanel);
			}
		}
	}
}

public enum Panels
{
	PROJECT_LIST_VIEW,
	PROJECT_EDIT_VIEW,
	NEW_PROJECT_VIEW,
}
