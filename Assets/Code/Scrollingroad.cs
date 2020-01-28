﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrollingroad : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSize;

	private Vector3 startPosition;

	void Start()
	{
		startPosition = transform.position;
	}

	void Update()
	{
		float newPosition = Mathf.Repeat(Time.realtimeSinceStartup * scrollSpeed, tileSize);
		transform.position = startPosition + Vector3.up * newPosition;
	}
}
