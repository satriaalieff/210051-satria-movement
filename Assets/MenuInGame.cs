using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInGame : MonoBehaviour
{
    public void BackToMainMenu() => SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);
}
