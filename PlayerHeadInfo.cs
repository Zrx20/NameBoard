using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Diagnostics;

public class PlayerHeadInfo : MonoBehaviour
{

    public Text m_LabelTitleBoard;
    public Sprite m_SprVip;
    public Text m_LabelName;
    public Sprite m_GuildBusinessState;
    public GameObject m_ObjChatBubble;
    public GameObject m_ObjOriginalHeadInfo;

    public GameObject l_ObjDropItemPop;
    public GameObject l_ObjDropGrid;

    //public ChatBubbleLogic m_ChatBubbleLogic;

    public GameObject m_ZiDongGuaJi;
    public GameObject m_ZiDongXunLu;

    //�һ��ı�ʶ
    public void ToggleGuaJi(bool b)
    {
        if (!m_ZiDongXunLu.activeSelf)
        {
            m_ZiDongGuaJi.SetActive(b);
        }
    }

    //�Զ�Ѱ·�ı�ʶ
    public void ToggleXunlu(bool b)
    {
        if (!m_ZiDongGuaJi.activeSelf)
        {
            m_ZiDongXunLu.SetActive(b);
        }
    }

    ///����VIP��Ϣ
    public void UpdateVipInfo(int nVipCost)
    {
        if (m_SprVip != null && m_LabelName != null)
        {
            //if (nVipCost > 0)
            //{
            //    m_SprVip.gameObject.SetActive(true);
            //    float fShiftx = m_LabelName.GetComponent<UIWidget>().localSize.x / 2.0f;
            //    fShiftx += m_SprVip.GetComponent<UIWidget>().localSize.x / 2.0f;

            //    float fShifty = m_SprVip.transform.localPosition.y;
            //    m_SprVip.transform.localPosition = new Vector3(-fShiftx, fShifty, 0);
            //    m_SprVip.spriteName = VipData.GetVipImage(nVipCost);
            //}
            //else
            //{
            //    m_SprVip.gameObject.SetActive(false);
            //}
        }
    }
    //������������
    public void UpdateGuildBusinessIcon(int iconState)
    {
        if (m_GuildBusinessState == null)
        {
            return;
        }
        switch (iconState)
        {
            case 1:
                //m_GuildBusinessState.gameObject.SetActive(true);
                //m_GuildBusinessState.spriteName = "ShangNon";
                //m_GuildBusinessState.MakePixelPerfect();
                break;

            case 2:
                //m_GuildBusinessState.gameObject.SetActive(true);
                //m_GuildBusinessState.spriteName = "ShangOk";
                //m_GuildBusinessState.MakePixelPerfect();
                break;

            default:
                //m_GuildBusinessState.gameObject.SetActive(false);
                break;
        }
    }
    //չʾTitleͨ��table
    public void ShowTitleInvestitiveByTable(int titleID, string strTitleInvestitive)
    {
        if (null != m_LabelTitleBoard)
        {
            //Tab_TitleData tabTitle = TableManager.GetTitleDataByID(titleID, 0);
            //if (tabTitle != null)
            //{
            //    string strTitle = "";
            //    strTitle += Utils.GetTitleColor(tabTitle.ColorLevel);
            //    strTitle += strTitleInvestitive;
            //    m_LabelTitleBoard.text = strTitle;
            //}
            //else
            //{
            //    m_LabelTitleBoard.text = "";
            //}
        }
    }

    //չʾ����
    public void ShowDropPop(int itemId)
    {
        if (null != l_ObjDropItemPop)
        {
            //			l_ObjDropItemPop.SetActive(true);
            //			l_ObjDropItemPop.GetComponent<HeadInfoDropItemManager> ().ShowNameLabel (itemName);

            string itemName = "";

            //GameItem item = new GameItem();
            //item.DataID = itemId;
            //if (item != null)
            //{
            //   // int nQuality = (int)item.GetQuality();
            //    //itemName = Utils.GetItemNameColor(nQuality);
            //    //itemName += TableManager.GetCommonItemByID(item.DataID, 0).Name;
            //}

            GameObject dropItem = (GameObject)Instantiate(l_ObjDropItemPop);
            dropItem.name = "Dropitem";
            dropItem.transform.parent = l_ObjDropGrid.transform;
            dropItem.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            dropItem.transform.localRotation = Quaternion.Euler(0, 0, 0);
            dropItem.transform.localPosition = new Vector3(-148.3f, 53.9f, 0f);
            //dropItem.GetComponent<HeadInfoDropItemManager>().ShowNameLabel(itemName);
        }
    }

    //չʾtitle
    public void ShowTitleInvestitive(string strTitleInvestitive)
    {
        m_LabelTitleBoard.text = strTitleInvestitive;
    }

    //չʾ�������Ϣ
    public void ShowOriginalHeadInfo(bool bShow)
    {
        if (null != m_ObjOriginalHeadInfo)
        {
            m_ObjOriginalHeadInfo.SetActive(bShow);
        }
    }

    //public void ShowChatBubble(ChatHistoryItem text)
    //{
    //    if (null != m_ChatBubbleLogic)
    //    {
    //        m_ChatBubbleLogic.Show(text);
    //    }
    //}
}
