/*
 * Created by SharpDevelop.
 * User: Daryl
 * Date: 10/13/2023
 * Time: 3:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Syntax4
{
	/// <summary>
	/// Description of Item.
	/// </summary>
	public class Item
	{
		public string[] listofitemNames = {"Small Biscuit", "Large Biscuit", "Small Potion", "Big potion"};
		public string[] listofitemEffects = {"strBuff", "strBuff", "hpHeal", "hpHeal"};
		public double[] itemEffectsStrength = {.50, 1, .50, 1};
		
		public int itemID;
		public string itemName;
		public string itemEffect;
		public double itemStrength; 
		public Item(int desiredID)
		{
			itemID = desiredID;
			itemName = listofitemNames[desiredID];
			itemEffect = listofitemEffects[desiredID];
			itemStrength = itemEffectsStrength[desiredID];
		}
	}
}
