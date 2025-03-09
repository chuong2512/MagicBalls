using System.Collections;
using System.Collections.Generic;
using Jackal;
using UnityEngine;

[DefaultExecutionOrder(-999)]
public class DataManager : PersistentSingleton<DataManager>
{
	public BallSkinData[] ballDatas;

	public Sprite CurrentBall()
	{
		for(int i=0;i<ballDatas.Length;i++)
		{
			if(ballDatas[i].id==GameData.SelectBallNum)
			{
				return ballDatas[i].Sprite;
			}
		}
		return ballDatas[0].Sprite;
	}
}
