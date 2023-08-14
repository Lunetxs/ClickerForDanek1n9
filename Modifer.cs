using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Modifer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _priceBasherUi;
    [SerializeField] private TextMeshProUGUI _priceBattleFuryUi;
    [SerializeField] private TextMeshProUGUI _priceMomUi;
    [SerializeField] private TextMeshProUGUI _priceRadianceUi;

    [SerializeField] private AudioSource buySound;

    private float _priceBasher = 25;
    private float _priceBattleFury =2500;
    private float _priceRadience = 6000;
    private float _priceMom = 17500;


    private int _buff;


    private void Start()
    {
        _priceBasherUi.text = Mathf.RoundToInt(_priceBasher).ToString();
        _priceBattleFuryUi.text = Mathf.RoundToInt(_priceBattleFury).ToString();
        _priceMomUi.text = Mathf.RoundToInt(_priceMom).ToString();
        _priceRadianceUi.text = Mathf.RoundToInt(_priceRadience).ToString();

    }


    public void BuyBasher()
    {
        _buff = 2;
        if (MainClick.money >= _priceBasher)
        {

            MainClick.money -= System.Convert.ToInt32(_priceBasher);
            MainClick.powerClicks += _buff;
            buySound.Play();
            _priceBasher *=  1.35f;
            _priceBasherUi.text = Mathf.RoundToInt(_priceBasher).ToString();
        }
        else Debug.Log("No money no funny");

    }
    public void BuyBattleFury()
    {
        _buff = 10;
        if (MainClick.money >= _priceBattleFury)
        {

            MainClick.money -= System.Convert.ToInt32(_priceBattleFury);
            MainClick.powerClicks += _buff;
            buySound.Play();
            _priceBattleFury *= 1.5f;
            _priceBattleFuryUi.text = Mathf.RoundToInt(_priceBattleFury).ToString();
        }
        else Debug.Log("No money no funny");

    }
    public void BuyMom()
    {
        _buff = 60;
        if (MainClick.money >= _priceMom)
        {

            MainClick.money -= System.Convert.ToInt32(_priceMom);
            MainClick.powerClicks += _buff;
            buySound.Play();
            _priceMom *= 1.8f;
            _priceMomUi.text = Mathf.RoundToInt(_priceMom).ToString();
        }
        else Debug.Log("No money no funny");

    }
    public void BuyRadiance()
    {
        _buff = 25;
        if (MainClick.money >= _priceRadience)
        {

            MainClick.money -= System.Convert.ToInt32(_priceRadience);
            MainClick.powerClicks += _buff;
            buySound.Play();
            _priceRadience *= 1.5f;
            _priceRadianceUi.text = Mathf.RoundToInt(_priceRadience).ToString();
        }
        else Debug.Log("No money no funny");

    }
    public void GiveMeMoneyBitch()
    {
        MainClick.money = 999999999;

    }
}
