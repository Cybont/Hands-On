using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {

	// send worker cards
	public List<GameObject> chosenWorkerCards;
	public GameObject currentWorkerCard;
	public bool sendCards;

	// send project cards'
	public GameObject sendProjectCard;

	// Cards
	public List<GameObject> projectCards;
	public List<GameObject> workerCards;

	// Game master script
	private GameMaster gameMaster;

	// Use this for initialization
	void Start () {
		gameMaster = FindObjectOfType<GameMaster> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (sendCards)
		{
			// changes the game masters project card to be = to the played project card
			gameMaster.projectCard = sendProjectCard;

			// emptys the list of send worker cards and sends them to the game master
			foreach (var item in chosenWorkerCards) 
			{
				currentWorkerCard = chosenWorkerCards[0];
				gameMaster.workerCards.Add(currentWorkerCard);
				chosenWorkerCards.Remove(chosenWorkerCards[0]);

				// removes cards from the plyers hand
				if (workerCards.Contains(currentWorkerCard))
				{
					workerCards.Remove(currentWorkerCard);
				}
			}

			// removes cards from the plyers hand
			if (projectCards.Contains(sendProjectCard))
			{
				projectCards.Remove(sendProjectCard);
			}

			sendCards = false;
			sendProjectCard = null;
			gameMaster.cardsSend = true;
		}
	}
}
