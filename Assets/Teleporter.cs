using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public string SceneName;
    public Vector3 Position;

    public void Teleport()
    {
        if(SceneManager.GetActiveScene().name.Equals(SceneName))
        {
            Debug.Log("Can't teleport to other places in the same scene");
        } else
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
