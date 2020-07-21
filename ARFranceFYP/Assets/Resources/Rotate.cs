using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	public GameObject et;
	public GameObject bou;
	public GameObject pdg;
	public GameObject lm;
	[SerializeField] Sprite[] rotateSprites;
	public float rotateSpeed = 50f;
	bool isRotating = false;
	public ObjectSelect OSRef;
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
		if (isRotating == true && OSRef.selectNo == 1)
		{
			et.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
		else if (isRotating == true && OSRef.selectNo == 3)
		{
			bou.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
		if (isRotating == true && OSRef.selectNo == 4)
		{
			pdg.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
		if (isRotating == true && OSRef.selectNo == 5)
		{
			lm.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		}
	}
}
