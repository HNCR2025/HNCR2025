using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ArraySeq : MonoBehaviour
{
    private List<Cube> cubi; // Lista di tutti i cubi
    public List<Cube> sequenzaCubi = new List<Cube>(); // Sequenza che cresce
    public Cube[] tuttiICubi; // <---- Dichiarato qui come variabile di classe
    private CollisionTest collisioni; // Riferimento al sistema di collisioni
    public Punti scritta;// Riferimento alla UI per il punteggio
    public SceneChanger chanceScene;// Gestore del cambio scena
    public int contCollision = 0;// Contatore delle collisioni avvenute
    public static int turno; // Numero del turno corrente
   
    public void Start()
    {
        turno = 1; // Inizializza il turno
        tuttiICubi = FindObjectsOfType<Cube>(); // <---- Ora è accessibile ovunque nella classe
        cubi = tuttiICubi.OrderBy(c => c.index).ToList(); // Ordina per indice
        collisioni = GetComponent<CollisionTest>(); // Assuming both scripts are on the same GameObject
        scritta = GetComponent<Punti>();// Ottiene il riferimento alla gestione della UI
        scritta.UpdateScritta(turno); // Aggiorna la UI con il turno iniziale
        StartCoroutine(Gioco());// Avvia il gioco come coroutineù

    }
    public IEnumerator Gioco()
    {
        while (true)
        {
            if (sequenzaCubi.Count == 0) // Se la sequenza è vuota, aggiunge un cubo
            {
                Cube nuovoCubo = cubi[Random.Range(0, cubi.Count)];
                sequenzaCubi.Add(nuovoCubo);
            }// Mostra la sequenza attuale ai giocatori

            foreach (Cube c in sequenzaCubi.ToArray())
            {
                c.Accendi(Color.blue); // metodo che accende il cubo
                yield return new WaitForSeconds(1f); // Visualizza la sequenza (1 secondo per cubo)
                c.Spegni(); // metodo che spegne il cubo
                yield return new WaitForSeconds(1f);// Attende prima di passare al successivo
            }
            // Attende che il giocatore riproduca la sequenza correttamente
            while (sequenzaCubi.Count != contCollision)
            {
                yield return null;
            }
            // Preparazione per il turno successivo
            contCollision = 0;
            turno++;
            scritta.UpdateScritta(turno);// Aggiorna la UI con il nuovo turno
                                         // Aggiunge un nuovo cubo alla sequenza per il turno successivo
            if (sequenzaCubi.Count > 0)
            {
                Cube nuovoCubo = cubi[Random.Range(0, cubi.Count)];
                sequenzaCubi.Add(nuovoCubo);
            }
        }
    }

    // Metodo per resettare il gioco
    public void ResetGame()
    {
        turno = 0;// Resetta il contatore dei turni
        scritta.UpdateScritta(1);// Resetta il contatore dei turni
        contCollision = 0;// Resetta il contatore delle collisioni
        sequenzaCubi.Clear(); // Svuota la sequenza corrente
        
    }
}

