using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class restartButtonCode : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {


            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
