using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
	public class PanelSwapperSingleton : MonoBehaviour
	{

		public PanelSwapper panelSwapper;
		private static PanelSwapperSingleton instance;

		private void Awake()
		{
			instance = this;
		}

		private PanelSwapperSingleton()
		{
			
		}

		public static PanelSwapperSingleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new GameObject("PanelSwapper").AddComponent<PanelSwapperSingleton>();
				}
				return instance;
			}
		}

		public void swapPanels(Panels panelToSwapTo)
		{
			if (panelSwapper == null)
			{
				panelSwapper = GameObject.FindObjectOfType<PanelSwapper>();
			}

			panelSwapper.SwapToPanel(panelToSwapTo);
		}
	}
}
