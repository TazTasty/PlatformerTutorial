using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winObjective : MonoBehaviour
{
   void OnCollisionEnter()
    {
        SceneManager.LoadScene("MeetingRia"); 
    }
}
