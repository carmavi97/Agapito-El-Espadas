using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Agapito")
        {
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
            SceneManager.LoadScene(2);
            SceneManager.UnloadScene(1);
        }
    }
}
