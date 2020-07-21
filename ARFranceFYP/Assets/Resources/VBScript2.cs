using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript2 : MonoBehaviour, IVirtualButtonEventHandler
{
	public GameObject vButton2;
	public GameObject crois;
	public GameObject steak;
	public GameObject cheese;
	//public GameObject crois;
	void Start()
	{
		vButton2 = GameObject.Find("vButton2");
		vButton2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		//crois.SetActive(true);
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		Debug.Log("Button Pressed");
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{

		if (crois.activeInHierarchy==true)
		{
			crois.SetActive(true);
		}
		else if (steak.activeInHierarchy==true)
		{
			steak.SetActive(false);
			crois.SetActive(true);
		}
		else if (cheese.activeInHierarchy==true)
		{
			cheese.SetActive(false);
			steak.SetActive(true);
		}
	}
	void update()
	{
	}
}
