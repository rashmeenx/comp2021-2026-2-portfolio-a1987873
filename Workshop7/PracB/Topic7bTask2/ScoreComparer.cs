using System;
using System.Collections.Generic;

public class ScoreComparer : IComparer<ScoreEntry>
{
    public int Compare(ScoreEntry? x, ScoreEntry? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException("ScoreEntry cannot be null");

        int scoreComparison = x.Score.CompareTo(y.Score);
        if (scoreComparison != 0)
            return scoreComparison;

        return x.StageReached.CompareTo(y.StageReached);
    }
}