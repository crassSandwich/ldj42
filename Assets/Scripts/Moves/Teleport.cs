﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : AMove
{
	public override void ApplyEffect(BoardPiece actingPiece, params BoardSpace[] spaces)
	{
		throw new System.NotImplementedException();
	}

	public override List<BoardSpace> GetLegalMoves(BoardPiece actingPiece, Board board)
	{
		throw new System.NotImplementedException();
	}
}
