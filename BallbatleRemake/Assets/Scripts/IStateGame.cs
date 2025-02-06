public interface IStateGame
{
    public bool IsGame
    {
        get
        {
            if (IsGame == false)
                return false;
            return true;
        }
        set
        {
            value = true;
        }
    }
}
