using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	public static MainController controller;
	public GameObject Frame;
	public Button btnInfo;
	public Button btnBuy;

	void Awake()
	{
		controller = this;
	}

	public void OnClickMarker(Marker marker)
	{
		Frame.gameObject.SetActive (true);
		switch (marker) 
		{
			case Marker.Bag:
				break;

			case Marker.Bottle:
				break;

			case Marker.Charger:
				break;

			case Marker.Mobile:
				break;

			case Marker.Monitor:
				break;
		}

	}

	public void OnClickInfo()
	{
		
	}

	public void OnClickBuy()
	{
		
	}


	public void OnClickClose()
	{
		Frame.SetActive (false);
	}
}
