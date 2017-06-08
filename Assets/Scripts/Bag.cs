using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour {

	void OnMouseDown()
	{
		MainController.controller.OnClickMarker(Marker.Bag);
	}
}
