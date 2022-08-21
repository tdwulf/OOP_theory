using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManager : MonoBehaviour
{
    [SerializeField] List<GameObject> ships;

    [SerializeField] GameObject statPanel;
    [SerializeField] TextMeshProUGUI statText;
    //public static MainManager Instance;
    public bool isGameActive;


    private void Start()
    {
        isGameActive = true;
        
    }


    public void WasClicked(Ship clickedShip)
    {
        statPanel.SetActive(true);
        SetLargeInactive();

        switch (clickedShip.tag)
        {
            case "blue":
                SetShipActive(0);
                break;

            case "red":
                SetShipActive(1);
                break;

            case "yellow":
                SetShipActive(2);
                break;

        }

        UpdateStatView(clickedShip);
    }

    private void SetLargeInactive()
    {
        for (int i = 0; i < ships.Count; i++)
        {
            ships[i].SetActive(false);
        }
    }

    private void SetShipActive(int index)
    {
        ships[index].SetActive(true);
    }

    private void UpdateStatView(Ship ship)
    {
        statText.text =
            "Speed: " + ship.ShowSpeed() + "<br>" +
            "Warp: " + ship.ShowWarp() + "<br>" +
            "Cargo: " + ship.ShowCargo() + "<br>" +
            "Shield: " + ship.ShowShield() + "<br>" +
            "Hull: " + ship.ShowHull() + "<br>" +
            "Dmg: " + ship.ShowDamage() + "<br>";
    }

}
