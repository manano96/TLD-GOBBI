using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ayuda2 : MonoBehaviour {

    private GameObject help01;
    private Image vidax;

    // Use this for initialization
    void Start()
    {
        help01 = GameObject.Find("Aiudaaa");
        help01.SetActive(false);

        vidax = GameObject.Find("vida").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (vidax.transform.localScale.x == 0 && other.tag == "Player")
        {
            help01.SetActive(true);
        }
    }
}
