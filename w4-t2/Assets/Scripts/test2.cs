using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class test2 : MonoBehaviour
{
    public GameObject test1;
    public GameObject test22;
    public GameObject test3;


    // Start is called before the first frame update
    void Start()
    {
       
        test1.transform.DOMove(new Vector3(10f, 4 ,0), 4f).SetEase(Ease.InBounce);
        test22.transform.DOMove(new Vector3(10f, 0f, 0), 4f).SetEase(Ease.OutBounce);
        test3.transform.DOMove(new Vector3(10f, -3f, 0), 4f).SetEase(Ease.InOutBounce);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
