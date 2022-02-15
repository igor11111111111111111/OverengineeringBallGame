
public class UIScoreHandler
{ 
    public void Init(Score score, ScorePanel panel)
    {
        score.OnCurrentChanged += panel.RefreshCurrent;
        score.OnMaxChanged += panel.RefreshMax;
    }
}
