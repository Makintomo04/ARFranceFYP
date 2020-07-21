using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler
{
	public GameObject vButton;
	public GameObject crois;
	public GameObject steak;
	public GameObject cheese;
	//public AudioSource audios;
	//public GameObject crois;
	void Start()
	{
		vButton = GameObject.Find("vButton");
		vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		//audios = GetComponent<AudioSource>();
		//crois.SetActive(true);
	}
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		Debug.Log("Button Pressed");
		//audios.Play();
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		
		if (crois.activeInHierarchy == true)
		{
			crois.SetActive(false);
			steak.SetActive(true);
		}
		else if (steak.activeInHierarchy == true)
		{
			steak.SetActive(false);
			cheese.SetActive(true);
		}
		else
		{
			crois.SetActive(false);
			steak.SetActive(false);
			cheese.SetActive(true);
		}
	}
	void update()
	{
	}
	}
	

