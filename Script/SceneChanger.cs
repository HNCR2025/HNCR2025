using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/** class used for changing the scene
*/
public class SceneChanger : MonoBehaviour
{
    /** ChangeScene is called every time a button on the menu is pressed
    */
    
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    /** Exit is called when the "Quit" button is pressed
    */
    public void Exit()
    {
        Application.Quit();
    }
}