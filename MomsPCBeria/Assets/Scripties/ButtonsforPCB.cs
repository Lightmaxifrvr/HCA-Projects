using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsforPCB : MonoBehaviour
{
    public GameObject HP;
    public GameObject VP;
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
        Instantiate(HP, new Vector3(0, 32, 0), Quaternion.identity);
    }

    public void VButton()
    {
        Instantiate(VP, new Vector3(0, 32, 0), Quaternion.identity);
    }
}
