using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ship : MonoBehaviour
{
    [SerializeField] GameObject statPanel;
    [SerializeField] TextMeshProUGUI statText;

    public float Speed;
    public int Warp;
    public float Cargo;
    public float Shield;
    public float Hull;
    public float Damage;

    public MainManager mainManager;
    

    private void Start()
    {
        mainManager = GameObject.Find("MainManager").GetComponent<MainManager>();
        Speed = 50;
        Warp = 1;
        Cargo = 50;
        Shield = 50;
        Hull = 50;
        Damage = 5;
    }

    public virtual int ShowSpeed()
    {
        return Mathf.RoundToInt(Speed);
    }
    public virtual int ShowWarp()
    {
        return Warp;
    }
    public virtual int ShowCargo()
    {
        return Mathf.RoundToInt(Cargo);
    }
    public virtual int ShowShield()
    {
        return Mathf.RoundToInt(Shield);
    }
    public virtual int ShowHull()
    {
        return Mathf.RoundToInt(Hull);
    }
    public virtual int ShowDamage()
    {
        return Mathf.RoundToInt(Damage);
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnMouseDown()
    {
        mainManager.WasClicked(this);

    }
}



