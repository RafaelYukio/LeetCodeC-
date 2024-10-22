using LeetCode.TopInterview150;

namespace LeetCode.Test
{
    public class _27RemoveElementTests
    {
        [Fact(DisplayName = "27. Remove Element")]
        public void GivenAValidArrayAndVal_WhenExecuted_ThenShouldReturnAnArrayWithoutVal()
        {
            //Arrange
            int[] nums = [3, 2, 2, 3];
            int val = 3;
            Tuple<int, int[]> expectedResult = new Tuple<int, int[]>(2, new int[] { 2, 2, 4, 4 });

            //Act
            var actualTuple = _27RemoveElement.Exercise(nums, val);

            //Assert
            Assert.Equal(expectedResult, actualTuple);
        }
    }
}