using UnityEngine;
using System.Collections;
using HandsOn;

namespace HandsOn {

public class GreenLightPeriod : MonoBehaviour {

	
	[SerializeField]private int periodTime = 10;

	public GreenLightPeriod(){
		StartCoroutine (GreenlightCorutine());
	}

	IEnumerator GreenlightCorutine()
	{
			cardsSend = false;
			int ListNumber = 0;
			
			foreach (var item in workerCards) 
			{
				if (cardIsvalid)
				{
					currentWorkerCard = workerCards[0];
					Debug.Log (currentWorkerCard);
					if (projectCard.GetComponent<ProjectCard> ().workerCardsNeeded.Contains(currentWorkerCard))
					{
						cardIsvalid = true;
					}
					else
					{
						cardIsvalid = false;
					}
					ListNumber++;
				}
			}
			yield return new WaitForSeconds (periodTime);
			
			if (cardIsvalid)
			{
				Debug.Log ("cards match");
			}
			else
			{
				Debug.Log ("cards dosent match");
			}
		return new WaitForSeconds (periodTime);
	}

}
}
