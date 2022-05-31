
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class testTween : MonoBehaviour
{
    private Button button; //goi nut
    public GameObject claim;
    public GameObject close;
    public TMP_Text quantity;
    public TMP_Text quantity2;
    // text for dia & gold
    public int diamon;
    public int gold;
    public int xxx;
    public int yyy;
    //slide gold
    public Slider goldSlider;
    public Slider diamondSlider;


    private void Awake()
    {
        claim.SetActive(false);
        diamondSlider.maxValue = 100;
        goldSlider.maxValue = 6000;
    }
    private void Start()
    {
        transform.DOScale(Vector3.one * 1.5f, 1f);
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick); //chay Onclick khi click vao
        close.GetComponent<Button>().onClick.AddListener(Close);
    }
    private void Update() //run text dia & gold
    {
        
        if (xxx <= diamon)
        {
            xxx += (60+ diamon)/60; // /60 <0 => = 0
            quantity.text = xxx.ToString();
            Debug.Log(xxx);
        }
        if (yyy <= gold)
        {
            if(yyy > 6000)
            {
                yyy = 6000;
            }
            else
            {
                yyy += gold / 60;
                quantity2.text = yyy.ToString();
                Debug.Log(yyy);
            }           
        }
        goldSlider.value = yyy;
        diamondSlider.value = xxx;
    }
    void OnClick()
    {
        transform.DOScale(Vector3.zero, 1f);
        claim.SetActive(true);
        diamon = Random.Range(20, 100);
        Debug.Log(diamon);
        gold = Random.Range(1000,6000);
        Debug.Log(diamon);

    }
    void Close()
    {
        claim.SetActive(false);
       
    }    
}
