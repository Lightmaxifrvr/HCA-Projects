using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.Rendering.DebugUI;

public class OrderTaking : MonoBehaviour
{
    private float customer;
    public float customerint;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;
    public GameObject SideView;
    public GameObject OrderView;
    public GameObject PCBView;
    public GameObject ShippingView;
    // Start is called before the first frame update
    void Start()
    {
        SelectCustomer();
        InstantiateCustomer();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SelectCustomer()
    {
        customer = Random.Range(1.0f, 5.0f);
        Debug.Log(customer);
        customerint = Mathf.RoundToInt(customer);
        Debug.Log(customerint);
    }

    void InstantiateCustomer()
    {
        if (customerint == 1)
        {
            Instantiate(Prefab1, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (customerint == 2)
        {
            Instantiate(Prefab2, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (customerint == 3)
        {
            Instantiate(Prefab3, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (customerint == 4)
        {
            Instantiate(Prefab4, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (customerint == 5)
        {
            Instantiate(Prefab5, new Vector3(0, 0, 0), Quaternion.identity);
        }
        StartCoroutine(WaitFor(8));



    }

    IEnumerator WaitFor(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        SideView.SetActive(false);
        OrderView.SetActive(true);

    }


    public void OnOrderPress()
    {
        PCBView.SetActive(false);
        ShippingView.SetActive(false);
        OrderView.SetActive(true);
    }
    public void OnPCBPress()
    {
        PCBView.SetActive(true);
        ShippingView.SetActive(false);
        OrderView.SetActive(false);
    }
    public void OnShippingPress()
    {
        PCBView.SetActive(false);
        ShippingView.SetActive(true);
        OrderView.SetActive(false);
    }
}