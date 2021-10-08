namespace FacadeDesignPattern
{
    public class FacadeExample : IFacadeExample
    {
        private readonly IConfusing _confusing;
        private readonly INonsense _nonsense;

        public FacadeExample(IConfusing confusing, INonsense nonsense)
        {
            _confusing = confusing;
            _nonsense = nonsense;
        }

        public void PrintAddingThreeNumbers(int x, int y, int z) => _nonsense.N(x, y, z);
        public string GetRollD20Message() => _confusing.MethodTwo();
        public string GetTheWordOne() => _confusing.MethodOne();
    }
}