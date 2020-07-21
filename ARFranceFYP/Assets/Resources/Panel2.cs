using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel2 : MonoBehaviour
{
    public GameObject Fact1;
    public GameObject Fact2;
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
            Fact2.SetActive(true);
        }
        else if (Fact2.activeSelf == true)
        {
            Fact1.SetActive(false);
            Fact2.SetActive(true);
        }
    }
    public void PreviousButton()
    {
        if (Fact2.activeSelf == true)
        {
            Fact2.SetActive(false);
            Fact1.SetActive(true);
        }
        if (Fact1.activeSelf == true)
        {
            Fact1.SetActive(true);
            Fact2.SetActive(false);
        }
    }

}
