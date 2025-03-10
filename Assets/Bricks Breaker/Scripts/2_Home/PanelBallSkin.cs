﻿using System;
using System.Collections.Generic;
using UnityEngine;

public enum CostType
{
	Default,
	Coin,
	Gem,
	Ads
}

[System.Serializable]
public class BallSkinData
{
	[HideInInspector] public int  id;
	[HideInInspector] public bool isUnlock;

	public string   ballName;
	public Sprite   Sprite;
	public CostType costType;
	public int      cost;
}

public class PanelBallSkin : PanelBase
{
	private BallSkinData[]          ballDatas;
	public  GameObject              pListSlot;
	public  Transform               listTransform;
	public  PanelBallSkinList       selectSkinList;
	public  List<PanelBallSkinList> panelBallLists=new List<PanelBallSkinList>();

	void Awake() { ballDatas=DataManager.Instance.ballDatas; }

	/// <summary>
	/// Ball Skin Data Settings
	///Set each list with the ball data.
	/// </summary>
	public override void SetData()
	{
		ballDatas=DataManager.Instance.ballDatas;
		for(int i=0;i<ballDatas.Length;i++)
		{
			ballDatas[i].id=i;
			GameObject obj=Instantiate(pListSlot);
			obj.transform.SetParent(listTransform,false);

			PanelBallSkinList skinList=obj.GetComponent<PanelBallSkinList>();
			skinList.ballSkinData=ballDatas[i];
			skinList.SetList();

			panelBallLists.Add(skinList);
		}

		panelBallLists[GameData.SelectBallNum].Select();
	}
}
