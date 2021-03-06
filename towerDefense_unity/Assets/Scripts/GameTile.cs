﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile : MonoBehaviour
{
    [SerializeField]
    Transform arrow = default;

    GameTile north, east, south, west, nextOnPath;

    int distance; //from this tile to end

    public int iinternalI;

    public void ClearPath()
    {
        distance = int.MaxValue;
        nextOnPath = null;
    }

    public void BecomeDestination()
    {
        distance = 0;
        nextOnPath = null;
    }
    public bool HasPath => distance != int.MaxValue;

    public static void MakeEastWestNeighbors(GameTile east, GameTile west)
    {
        Debug.Assert(east.west == null && west.east == null, "Redefined Neighboors!");
        west.east = east;
        east.west = west;
    }

    public static void MakeNorthSouthNeighbors(GameTile north, GameTile south)
    {
        Debug.Assert(north.south == null && south.north == null, "Redefined Neighbors!");
        north.south = south;
        south.north = north;
    }
}
