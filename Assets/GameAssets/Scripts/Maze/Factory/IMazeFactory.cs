﻿ using Assets.GameAssets.Scripts.Maze.Model;

namespace Assets.GameAssets.Scripts.Maze.Factory
{
    public interface IMazeFactory
    {
        IMazeCarver GetMazeCarver(IModelBuilder modelBuilder);
    }
}