using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public GameObject button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button.GetComponent<Button>().onClick.AddListener(upd);
    }
    private void upd()
    {
        int x = Random.Range(0, 10);
        Debug.Log(x);
    }
}
