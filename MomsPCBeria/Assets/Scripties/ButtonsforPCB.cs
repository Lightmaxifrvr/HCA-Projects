using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsforPCB : MonoBehaviour
{
    public GameObject HP;
    public GameObject VP;
    public GameObject HVP;
    public GameObject VHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void HButton()
    {
        Instantiate(HP);
    }

    public void VButton()
    {
        Instantiate(VP);
    }

    public void HVButton()
    {
        Instantiate(HVP);
    }

    public void VHButton()
    {
        Instantiate(VHP);
    }
}
