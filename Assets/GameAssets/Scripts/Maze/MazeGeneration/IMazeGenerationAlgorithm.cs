﻿using Assets.GameAssets.Scripts.Maze.Model;

namespace Assets.GameAssets.Scripts.Maze.MazeGeneration
{
    public interface IMazeGenerationAlgorithm
    {
        AlgorithmRunResults GenerateMaze(IMazeCarver maze, MazeGenerationSettings settings);
    }
}