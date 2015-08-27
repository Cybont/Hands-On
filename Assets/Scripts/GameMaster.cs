using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using HandsOn;

namespace HandsOn {

public class GameMaster : MonoBehaviour {

	// played cards
	public List<GameObject> workerCards;
	public GameObject projectCard;
	public bool cardsSend;
	public GameObject currentWorkerCard;
	public bool cardIsvalid;
	private GreenLightPeriod greenlightStart;

	// timers
	public float waitBeforeCheckingCards;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (cardsSend)
		{
			SgreenlightStart = new GreenLightPeriod();
		}
	}

	
}
