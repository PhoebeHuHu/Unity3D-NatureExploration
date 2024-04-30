using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DistroyElse : MonoBehaviour
{
    public GameObject gameObjectToDelete;
    public void DeleteGameObject(GameObject gameObjectToDelete)
    {
        if (gameObjectToDelete != null)
        {
            //Destroy(gameObjectToDelete);
            gameObjectToDelete.SetActive(false);
        }
        else
        {
            Debug.Log("Attempted to delete a null GameObject.");
        }
    }
}
