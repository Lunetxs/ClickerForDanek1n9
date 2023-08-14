using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MainClick : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyUi;
    [SerializeField] private GameObject mob;
    [SerializeField] public static int powerClicks;
    public static int money;


    private void Awake()
    {
        money = 0;
        powerClicks = 1;
    }

    public void ClickedDown()
    {

        money += powerClicks;
        mob.GetComponent<RectTransform>().localScale = new Vector3(55f, 55f, 55f);
    }
    public void onCLickUp()
    {

        mob.GetComponent<RectTransform>().localScale = new Vector3(66f, 66f, 66f);
    }

    private void Update()
    {
        moneyUi.text = money.ToString();
        if(money <= 0)
        {
            money = 0;
        }
    }
}
