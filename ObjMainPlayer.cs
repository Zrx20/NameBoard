using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ������  ��Ҫ�̳�Obj
/// </summary>
public class ObjMainPlayer : MonoBehaviour
{
    protected GameObject m_HeadInfoBoard;        // ͷ����Ϣ���ܽڵ�
    public PlayerHeadInfo m_playerHeadInfo;
    protected Text m_NameBoard;              // ���ְ� ����obj����
    // Start is called before the first frame update
    void Start()
    {
        
        InitNameBoard();
    }

    //��ʼ��
    private void InitNameBoard()
    {
        //����ͷ����Ϣ��Prefab
        //ResourceManager.LoadHeadInfoPrefab(UIInfo.PlayerHeadInfo, gameObject, "PlayerHeadInfo", OnLoadNameBoard);
    }

    //����
    public void OnLoadNameBoard(GameObject objNameBoard)
    {
        m_HeadInfoBoard = objNameBoard;
        if (null != m_HeadInfoBoard)
        {
            m_playerHeadInfo = m_HeadInfoBoard.GetComponent<PlayerHeadInfo>();
            if (null != m_playerHeadInfo)
            {
                m_NameBoard = m_playerHeadInfo.m_LabelName;
            }
        }
        ShowNameBoard();
        ShowPlayerTitleInvestitive();
        //UpdateVipInfo();
    }
    //չʾ
    public void ShowNameBoard()
    {
        if (null == m_NameBoard)
        {
            return;
        }

        //if (PlayerPreferenceData.SystemNameBoard == 0)
        //{
        //    CloseNameBoard();
        //}
        //else
        //{
        //    if (ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_OTHER_PLAYER ||
        //        ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_MAIN_PLAYER ||
        //        ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_ZOMBIE_PLAYER)
        //    {
        //        Obj_OtherPlayer player = this as Obj_OtherPlayer;
        //        if (null != player && null != player.m_playerHeadInfo)
        //        {
        //            player.m_playerHeadInfo.ShowOriginalHeadInfo(true);
        //            player.UpdateGBNameBoard();
        //        }
        //        SetNameBoardColor();
        //        m_NameBoard.text = BaseAttr.RoleName;
        //    }
        //    else if (ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_NPC ||
        //        ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_FELLOW)
        //    {
        //        m_NameBoard.gameObject.SetActive(true);
        //        SetNameBoardColor();
        //        m_NameBoard.text = BaseAttr.RoleName;
        //    }
        //}
        // �������ְ�߶ȵĲ����Ƶ�billboard�ű���update��ִ��
    }
    //�ر�
    public void CloseNameBoard()
    {
        if (null == m_NameBoard)
        {
            return;
        }

        //if (ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_OTHER_PLAYER ||
        //    ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_MAIN_PLAYER ||
        //    ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_ZOMBIE_PLAYER)
        //{
        //    Obj_OtherPlayer player = this as Obj_OtherPlayer;
        //    if (null != player && null != player.m_playerHeadInfo)
        //    {
        //        player.m_playerHeadInfo.ShowOriginalHeadInfo(false);
        //    }
        //}
        //else if (ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_NPC ||
        //        ObjType == GameDefine_Globe.OBJ_TYPE.OBJ_FELLOW)
        //{
        //    m_NameBoard.gameObject.SetActive(false);
        //}
    }
    //չʾ
    public void ShowPlayerTitleInvestitive()
    {
        if (null != m_playerHeadInfo)
        {
            //m_playerHeadInfo.ShowTitleInvestitive(GameManager.gameManager.PlayerDataPool.TitleInvestitive.GetCurrentTitle());
        }
    }

    //�̳�ˢ��Vip��Ϣ��
    //public override void UpdateVipInfo()
    //{
    //    base.UpdateVipInfo();
    //    OnVipCostChange();
    //}

    //vip���Ѹı�
    public void OnVipCostChange()
    {
        //if (PlayerFrameLogic.Instance() != null)
        //{
        //    PlayerFrameLogic.Instance().OnVipCostChange(VipCost);
        //}
        //if (RechargeBarLogic.Instance() != null)
        //{
        //    RechargeBarLogic.Instance().OnVipCostChange(VipCost);
        //}
        //if (DungeonWindow.Instance() != null)
        //{
        //    DungeonWindow.Instance().UpdateTabInfo();
        //}
        //             if (VipData.GetVipLv() == GlobeVar.USE_AUTOFIGHT_VIPLEVEL)
        //             {
        //                 //vip2��ʱ��ѡ���Զ�ǿ��
        //                 UpdateSelectEquip();
        //             }
    }
}
