using System.Collections.Generic;
using UnityEngine;

public class Grid {
    /// <summary>
    /// The tiles for this grid.
    /// </summary>
    private readonly Tile[,] _grid;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="width">Width of the grid (amount of columns)</param>
    /// <param name="height">Height of the grid (amount ofrows)</param>
    public Grid(int width, int height) {
        if(width < 0 || height < 0) {
            throw new System.InvalidOperationException("width and height cannot be smaller than zero");
        }
        
        Width = width;
        Height = height;

        _grid = new Tile[Width, Height];

        for(int x = 0; x < Width; x++) {
            for(int y = 0; y < Height; y++) {
                Vector3 currentPosition = new Vector3(x, y, 0);
                _grid[x, y] = new Tile(currentPosition);
            }
        }
    }

    /// <summary>
    /// The width of the grid.
    /// </summary>
    public int Width {
        get; set;
    }

    /// <summary>
    /// The height of the grid.
    /// </summary>
    public int Height {
        get; set;
    }

    /// <summary>
    /// Gets a Tile from the grid.
    /// </summary>
    /// <param name="x">x position of the tile.</param>
    /// <param name="y">y position of the tile.</param>
    /// <returns></returns>
    public Tile GetTile(int x, int y) {
        // todo 1: ik return nu 'null'. Zorg ervoor dat jullie de Tile returnen die op plek x en y staat in ons grid

        // todo 2: bouw een check in of de x en y wel binnen het grid valt
        if(IsOnGrid(x, y)) {
            return _grid[x, y];
        } else {
            throw new System.InvalidOperationException("index past niet in de grid");
        }
    }

    /// <summary>
    /// Determines if a x & y position is within the grid
    /// </summary>
    /// <param name="x"></param>
    /// <param name="z"></param>
    /// <returns></returns>
    public bool IsOnGrid(int x, int y) {
        // todo: nu return ik altijd true. Zorg ervoor dat er echt gecheckt wordt of de x en y binnen het grid vallen
        if(x < 0 || x > Width) {
            return false;
        }

        if(y < 0 || y > Height) {
            return false;
        }
        
        return true;
    }

}