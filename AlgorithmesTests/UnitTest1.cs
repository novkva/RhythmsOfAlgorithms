using YaAlgorithms;

namespace AlgorithmesTests
{
    public class UnitTest1
    {
        [Fact]
        public void FaktorizationTrue()
        {
            var fakt = Faktorization.Do(100);
            var expected = new List<int> {2, 2, 5, 5 };
            Assert.Equal(expected, fakt);
        }
    }
}