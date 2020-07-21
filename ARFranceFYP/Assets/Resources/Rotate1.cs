using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
public class Rotate1 : MonoBehaviour
{

	public GameObject crois;
	public GameObject steak;
	public GameObject cheese;
	public GameObject wine;
	//public GameObject pdg;
	//public GameObject lm;
	[SerializeField] Sprite[] rotateSprites;
	public float rotateSpeed = 25f;
	bool isRotating = false;
	public ObjectSelectCuisine OSRef;
	void Start()
	{
		
	}
		public void RotateObject()
		{

			if (isRotating == false)
			{
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = rotateSprites[1];
			isRotating = true;
			
			}
			else
			{
			gameObject.GetComponent<UnityEngine.UI.Image>().sprite = rotateSprites[0];
			isRotating = false;
			}
		}

		void Update()
	{
		if (isRotating == true && crois.activeInHierarchy)
		{
			crois.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
		else if (isRotating == true && steak.activeInHierarchy)
		{
			steak.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
		else if (isRotating == true && cheese.activeInHierarchy)
		{
			cheese.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
		else if (isRotating == true && wine.activeInHierarchy)
		{
			wine.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
		//if (isRotating == true && OSRef.selectNo == 5)
		//{
		//lm.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		//}
	}
}
