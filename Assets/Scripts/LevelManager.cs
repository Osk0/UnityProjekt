using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //czas do zakonczenia poziomu
    public float timeLeft = 90f;

    //elementy UI
    public GameObject TimeCounter;
    public GameObject GameOverOverlay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //zmniejsz ilosc czasu pozosta³ego na wykonanie poziomu
        //o czas, który min¹³ od ostaniej klatki
        timeLeft -= Time.deltaTime;



        //aktualizuj UIojhojhohj
        UpdateUI();
    }

    void UpdateUI()
    {
        //funkcja odpowiedzialna za aktualizacjê interfejsu u¿ytkownika

        TimeCounter.GetComponent<TextMeshProUGUI>().text = "Pozosta³y czas:" + Mathf.Floor(timeLeft).ToString();

        if (timeLeft <= 0)
            GameOverOverlay.SetActive(true); 
    }
    public void OnWin()
    {
        GameOverOverlay.SetActive(true);
        GameOverOverlay.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Wygrałeś!";
    }
    public void OnLose()
    {
        GameOverOverlay.SetActive(true);
        GameOverOverlay.transform.Find("ReasonText").GetComponent<TextMeshProUGUI>().text = "Kamera cię zobaczyła";
    }
} 
