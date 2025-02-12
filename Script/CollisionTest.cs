using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionTest : MonoBehaviour
{
    public ArraySeq arrayCubi;// Riferimento allo script ArraySeq che gestisce la sequenza dei cubi
    // Metodo chiamato automaticamente quando un Collider entra in collisione con il
    // Collider attaccato a questo GameObject
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sphere")// Controlla se l'oggetto in collisione ha il tag "sphere"
        {
            if (arrayCubi == null)// Se il riferimento arrayCubi non è stato ancora assegnato, lo cerca nella scena
            {
                arrayCubi = FindObjectOfType<ArraySeq>();
            }
            // Avvia una coroutine per gestire la logica della collisione
            StartCoroutine(CollisionDetect());
        }
    }


    // Coroutine che gestisce il comportamento in seguito alla collisione
    private IEnumerator CollisionDetect()
    {
        // Verifica se l'indice del cubo nella sequenza (in base al contatore di collisioni)
        // corrisponde all'indice del cubo coinvolto nella collisione
        if (arrayCubi.sequenzaCubi[arrayCubi.contCollision].index == this.GetComponent<Cube>().index)
        {
            // Se l'indice corrisponde, imposta il colore del cubo su verde (collisione corretta)
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            yield return new WaitForSeconds(2f);// Attende 2 secondi prima di procedere
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
            arrayCubi.contCollision++;
        }
        else
        {
            // Se l'indice non corrisponde, imposta il colore del cubo su rosso
            // (errore nella sequenza)
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
            yield return new WaitForSeconds(2f);
            this.gameObject.GetComponent<Renderer>().material.color = Color.white;
            SceneManager.LoadScene("scena_end2");
            PunteggioFinale.UpdateScritta(ArraySeq.turno);
            yield return new WaitForSeconds(2f);
            arrayCubi.ResetGame();
            yield return new WaitForSeconds(2f);
        }
    }
}