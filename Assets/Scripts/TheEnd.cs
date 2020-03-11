using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour
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
            SceneManager.LoadScene(4, LoadSceneMode.Additive);
            SceneManager.LoadScene(4);
            SceneManager.UnloadScene(2);
        }
    }
}
