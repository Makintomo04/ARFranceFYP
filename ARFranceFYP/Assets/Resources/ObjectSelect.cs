using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSelect : MonoBehaviour
{
    private Text label;
    private GameObject labelBG;
   // public Text selected;
    public int selectNo;
    public string RaycastReturn;
   // public GameObject Foundobject;

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

        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                labelBG.SetActive(true);
                label.text = hit.transform.name.ToString();
              //  selected.text = hit.transform.name.ToString();
                if (hit.collider.gameObject.CompareTag("Eiffel Tower"))
                {
                    //RaycastReturn = hit.collider.gameObject.name;
                    selectNo = 1;
                    Debug.Log("ET");
                }
                if (hit.collider.gameObject.CompareTag("Notre Dame"))
                {
                    selectNo = 2;
                    Debug.Log("ND");
                }
            }
            else
            {
                labelBG.SetActive(false);
                label.text = "";
            }
        }
        

        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                labelBG.SetActive(true);
                label.text = hit.transform.name.ToString();
                //selected.text = hit.transform.name.ToString();
                if (hit.collider.gameObject.CompareTag("Eiffel Tower"))
                {
                    //RaycastReturn = hit.collider.gameObject.name;
                    selectNo = 1;
                    Debug.Log("ET");
                }
                else if (hit.collider.gameObject.CompareTag("Notre Dame"))
                {
                    selectNo = 2;
                    Debug.Log("ND");
                }
                
            }
            else
            {
                selectNo = 0;
                labelBG.SetActive(false);
                label.text = "";
            }
        }
    }
    }

