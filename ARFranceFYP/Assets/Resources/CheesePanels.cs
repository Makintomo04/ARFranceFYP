using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheesePanels : MonoBehaviour
{
    public GameObject Fact1;
    public GameObject Fact2;
    public GameObject Fact3;
    public GameObject IMG;
    public GameObject HEAD;
    public GameObject Fact2IMG;
    public GameObject Fact2HEAD;
    public GameObject Fact3IMG;
    public GameObject Fact3HEAD;
    // Start is called before the first frame update
    void Start()
    {
        Fact1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextButton()
    {
        if (Fact1.activeSelf == true)
        {
            Fact1.SetActive(false);
            IMG.SetActive(false);
            HEAD.SetActive(false);
            Fact2.SetActive(true);
            Fact2IMG.SetActive(true);
            Fact2HEAD.SetActive(true);
        }
        else if (Fact2.activeSelf == true)
        {
            Fact1.SetActive(false);
            Fact2.SetActive(false);
            Fact3.SetActive(true);
            Fact2IMG.SetActive(false);
            Fact2HEAD.SetActive(false);
            Fact3IMG.SetActive(true);
            Fact3HEAD.SetActive(true);
        }
        else
        {
            Fact3.SetActive(true);
        }
    }
    public void PreviousButton()
    {
        if (Fact2.activeSelf == true)
        {
            Fact2.SetActive(false);
            Fact1.SetActive(true);
            IMG.SetActive(true);
            HEAD.SetActive(true);
            Fact2IMG.SetActive(false);
            Fact2HEAD.SetActive(false);
        }
        if (Fact3.activeSelf == true)
        {
            Fact3.SetActive(false);
            Fact2.SetActive(true);
            Fact2IMG.SetActive(true);
            Fact2HEAD.SetActive(true);
            Fact3IMG.SetActive(false); 
            Fact3HEAD.SetActive(false);
        }
    }
}
