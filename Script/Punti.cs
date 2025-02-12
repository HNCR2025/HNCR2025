using System.Collections;
using System.Collections.Generic;
using TMPro; // Namespace per l'utilizzo di TextMeshPro
using UnityEngine;
using UnityEngine.UI;
public class Punti : MonoBehaviour
{
    // Riferimento all'elemento UI che mostra il punteggio/round
    public TextMeshProUGUI punteggio;
    // Metodo Start, chiamato all'avvio del gioco o dell'oggetto
    void Start()
    {
        // Cerca l'oggetto nella scena con nome "punteggio" e ne ottiene il componente TextMeshProUGUI
        punteggio = GameObject.Find("punteggio").GetComponent<TextMeshProUGUI>();
        // Aggiorna la scritta con il round iniziale impostato a 1
        UpdateScritta(1);
    }

    // Metodo pubblico per aggiornare il testo visualizzato in UI con il round corrente
    public void UpdateScritta(int turno)
    {
        if (punteggio != null)// Controlla che il riferimento all'oggetto TextMeshProUGUI non sia nullo
        {
           punteggio.text = "Round: " + turno; // Imposta il testo visualizzato con il formato "Round: [numero_round]"
        }

    }
    public void UpdateScrittaFinale(int turno)
    {
        punteggio.text = "Score: " + turno;
    }
}
