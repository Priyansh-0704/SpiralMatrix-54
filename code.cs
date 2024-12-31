public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            return new List<int>(); // Handle edge case for empty matrices

        int m = matrix.Length; 
        int n = matrix[0].Length;
        var result = new List<int>();

        int top = 0, bottom = m - 1;
        int left = 0, right = n - 1;

        while (top <= bottom && left <= right)
        {
            // Traverse from left to right along the top boundary
            for (int col = left; col <= right; col++)
                result.Add(matrix[top][col]);
            top++; // Move the top boundary down

            // Traverse from top to bottom along the right boundary
            for (int row = top; row <= bottom; row++)
                result.Add(matrix[row][right]);
            right--; // Move the right boundary left

            // Traverse from right to left along the bottom boundary
            if (top <= bottom)
            {
                for (int col = right; col >= left; col--)
                    result.Add(matrix[bottom][col]);
                bottom--; // Move the bottom boundary up
            }

            // Traverse from bottom to top along the left boundary
            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                    result.Add(matrix[row][left]);
                left++; // Move the left boundary right
            }
        }
        return result;
    }
}
