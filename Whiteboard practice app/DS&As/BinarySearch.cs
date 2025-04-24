public class BinarySearch {
    public bool SearchMatrix(int[][] matrix, int target) {
        int i = 0;
        while(i < matrix.Length)
        {
            int j = matrix[i].Length - 1;
            if(target > matrix[i][j]) i++;
            else {
                while(j >= 0 && target <= matrix[i][j])
                {
                    if(matrix[i][j] == target) return true;
                    j--;
                }
                i++;
            }
        }
        return false;
    }
}