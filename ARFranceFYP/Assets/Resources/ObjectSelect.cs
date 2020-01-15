using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelect : MonoBehaviour
{
    private Text label;
    private GameObject labelBG;

    // Start is called before the first frame update
    void Start()
    {
        label = GameObject.Find("LabelText").GetComponent<Text>();
        label.text = "";

        labelBG = GameObject.Find("LabelBGText");
        labelBG.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                labelBG.SetActive(true);
                label.text = hit.transform.name.ToString();
            }
            else
            {
                labelBG.SetActive(false);
                label.text = "";
            }
        }
        */

        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                labelBG.SetActive(true);
                label.text = hit.transform.name.ToString();
            }
            else
            {
                labelBG.SetActive(false);
                label.text = "";
            }
        }
    }
    }

