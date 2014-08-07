using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PointsDeck : CardDeck {
	public CardAtlas Atlas;
	public CardStock Stock;
	
	public override void Initialize()
	{
		Debug.Log("Atlas = "+Atlas.name);
		string [] suits = new string[]{"Heart","Spade","Diamond","Club"};
		string [] prefixes = new string[]{"H-","S-","D-","C-"};
		List<CardDef> defs = new List<CardDef>();
		for (int i=0; i<4; ++i)
		{
			int ii = i*3;
			string symbol = suits[i];
			defs.Add( new CardDef(Atlas,Stock,"8",symbol,8) );
			defs.Add( new CardDef(Atlas,Stock,"9",symbol,9) );
			defs.Add( new CardDef(Atlas,Stock,"10",symbol,10) );
		}
		
		m_itemList = new DeckItem[12];
		for (int i=0; i<defs.Count; ++i)
		{
			DeckItem item = new DeckItem();
			item.Count = 1;
			item.Card = defs[i];
			m_itemList[i] = item;
		}
	}
}
