using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBtn : MonoBehaviour
{
    [SerializeField] private Image customImage;
    [SerializeField] private Text info;
    private bool isCollide;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //customImage.enabled = true;      
            info.enabled = true;
            isCollide = true;
            print("info enabled");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //customImage.enabled = false;
            info.enabled = false;
            isCollide = false;
            print("info desabled");
        }
    }

    private void Update()
    {
        //if (Input.GetKeyDown("i") && isCollide == true)
        //{
        //    print("i  key is held down");
        //    customImage.enabled = true;
        //}
        if (Input.GetMouseButtonDown(0) && isCollide == true)
        {
            print("left click");
            customImage.enabled = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            print("right click");
            customImage.enabled = false;
        }

            
    }
}
