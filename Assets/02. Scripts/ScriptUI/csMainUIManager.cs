using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csMainUIManager : MonoBehaviour
{
    [Header("Canvas Usual")]
    bool isSetting;
    bool isCommunity;

    public GameObject pnlSetting;
    public RectTransform pnlCommunity;

    [Header("Canvas Main")]
    public Canvas cvMain;

    [Header("Canvas Lobby")]
    public Canvas cvLobby;


    private void Start()
    {
        cvMain.enabled = true;
        cvLobby.enabled = false;
    }

    private void Update()
    {
 
        if(!cvLobby.enabled && !isSetting && Input.GetKeyDown(KeyCode.Escape))
        {
            isSetting = true;
            pnlSetting.SetActive(true);
        }
        else if (isSetting && Input.GetKeyDown(KeyCode.Escape))
        {
            isSetting = false;
            pnlSetting.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            ChangeLobbytoMain();
        }
    }

    #region cvUsual
    public void OnClickUsualSetting()
    {
        isSetting = true;
        pnlSetting.SetActive(true);
    }

    public void OnClickUsualClose()
    {
        isSetting = false;
        pnlSetting.SetActive(false);
    }

    public void OnClickUsualExit()
    {
        Application.Quit();
    }

    public void OnClickUsualCommunity()
    {
        if (!isCommunity)
        {
            isCommunity = true;
            Vector2 pos = new Vector2(-150f, -40f);
            pnlCommunity.anchoredPosition = pos;
        }
        else
        {
            isCommunity = false;
            Vector2 pos = new Vector2(60f, -40f);
            pnlCommunity.anchoredPosition = pos;
        }
    }

    #endregion

    #region cvMain

    private void ChangeMaintoLobby()
    {
        cvMain.enabled = false;
        cvLobby.enabled = true;
    }
    public void OnclickMainPlay()
    {
        ChangeMaintoLobby();
    }
    public void OnclickMainCareer()
    {
        ChangeMaintoLobby();
    }
    public void OnclickMainBattlepass()
    {
        ChangeMaintoLobby();
    }
    public void OnclickMainCollection()
    {
        ChangeMaintoLobby();
    }
    public void OnclickMainAgent()
    {
        ChangeMaintoLobby();
    }
    public void OnclickMainStore()
    {
        ChangeMaintoLobby();
    }
    #endregion


    #region cvLobby
    private void ChangeLobbytoMain()
    {
        cvLobby.enabled = false;
        cvMain.enabled = true;
    }


    #endregion

}
