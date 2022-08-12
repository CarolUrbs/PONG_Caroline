using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ChangeNameBase : MonoBehaviour
{
    #region vari�veis
    [Header("References")]
    [SerializeField]
    public TextMeshProUGUI uiTextName;
    public TMP_InputField uiInputFieldName;
    public GameObject changeNameInput;
    
    private string playerName;
    #endregion
    #region m�todos
    public void ChangeName()
    {
        playerName= uiInputFieldName.text;
        uiTextName.text = uiInputFieldName.text;
        changeNameInput.SetActive(false);
    }
    #endregion
}
