using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFoodItem : MonoBehaviour
{
	public GameObject crois;
	public GameObject steak;
	public GameObject cheese;
	public GameObject wine;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void NextFood()
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
		else if (cheese.activeInHierarchy == true)
		{
			cheese.SetActive(false);
			wine.SetActive(true);
		}
		else
		{
			wine.SetActive(false);
			crois.SetActive(true);
		}
	}
}
