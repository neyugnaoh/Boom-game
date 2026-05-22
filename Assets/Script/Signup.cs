using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Signup : MonoBehaviour
{
    public GameObject passwordField;
    public GameObject repasswoldFeild;
    public GameObject errorPopup;
    public void confirmClicked()
    {
        if (passwordField.GetComponent<TMP_InputField>().text == repasswoldFeild.GetComponent<TMP_InputField>().text)
        {
            SceneManager.LoadScene(3);
        }
        errorPopup.SetActive(true);
    }

}
