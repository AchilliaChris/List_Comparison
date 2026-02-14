using List_Comparison;

namespace ListComparisonTests
{
    public class ComparisonUnitTests
    {

        [Fact]
        public void SwapLists_ByValue_DoesNotSwapOriginalLists()
        {
            var listA = new List<int> { 1, 2, 3 };
            var listB = new List<int> { 4, 5, 6 };

            // Invoke by-value swap; original lists should remain unchanged.
            Program.SwapLists(listA, listB);

            Assert.Equal(new List<int> { 1, 2, 3 }, listA);
            Assert.Equal(new List<int> { 4, 5, 6 }, listB);
        }

        [Fact]
        public void SwapLists_ByRef_SwapsReferences()
        {
            var listA = new List<int> { 1, 2, 3 };
            var listB = new List<int> { 4, 5, 6 };
            var newListA = listB;
            var newListB = listA;

            
            // Invoke by-ref swap; lists should swap.
            Program.SwapLists(ref listA, ref listB);

            Assert.Equal(new List<int> { 4, 5, 6 }, newListA);
            Assert.Equal(new List<int> { 1, 2, 3 }, newListB);
        }

        [Fact]
        public void AddValueToList_AppendsValue()
        {
            var list = new List<int> { 1, 2 };

            Program.AddValueToList( list, 5 );

            Assert.Contains(5, list);
            Assert.Equal(3, list.Count);
        }
    }
}
