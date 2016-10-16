using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
	public class ProjectListItem : MonoBehaviour
	{
		public Text TitleText;

		public void OpenProject()
		{
			PanelSwapperSingleton.Instance.swapPanels(Panels.PROJECT_EDIT_VIEW);
		}
	}
}
