﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menang : MonoBehaviour
{
  public void QuitGame()
  {
      Application.Quit();
  }
  
  public void BackMenu()
  {
      SceneManager.LoadScene("MainMenu");
  }
}
