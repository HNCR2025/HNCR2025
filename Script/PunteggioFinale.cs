using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PunteggioFinale: MonoBehaviour
{
    public static TextMeshProUGUI punteggiofinale;
    // Metodo Start, chiamato all'avvio del gioco o dell'oggetto
    
    
    void Start()
    {
        // Cerca l'oggetto nella scena con nome "punteggio" e ne ottiene il componente TextMeshProUGUI
        punteggiofinale = GameObject.Find("punteggiofinale").GetComponent<TextMeshProUGUI>();
        UpdateScritta(ArraySeq.turno);
    }
    // Metodo pubblico per aggiornare il testo visualizzato in UI con il round corrente
    public static void UpdateScritta(int turno)
    {
        //punteggiofinale = GameObject.Find("punteggiofinale").GetComponent<TextMeshProUGUI>();
        if (punteggiofinale != null)// Controlla che il riferimento all'oggetto TextMeshProUGUI non sia nullo
        { 
           punteggiofinale.text = "Il punteggio finale è: " + turno; // Imposta il testo visualizzato con il formato "Round: [numero_round]"
        }
    }
}
