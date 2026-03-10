public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // ___________________________________________________________________________

        // 1. First I create an Array of double that I call results of size - length
        // 2. I use a for loop to populate the array using the relation: 
        // results[i] = number * (double)(i + 1);
        // 3. I return the array results

        double[] results = new double[length];
        // results[0] = number;
        for (int i = 0; i < length; i++)
        {
            results[i] = number * (double)(i + 1);
        }

        return results; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // 1. I start by subtracting the given amount from the size of the data list to get the index of the element that would be the first element of the results array, I store this value in a variable called indexValue. 

        int indexValue = data.Count - amount;

        // 2. Using a for loop I add more elements, (the number of elements I add is equal to indexValue) to the end of the results List

        for (int i = 0; i < indexValue; i++)
        {
            data.Add(data[i]);
        }

        // 3. I finally use the RemoveRange method to remove exactly indexValue number of elements from the start of the data List.

        data.RemoveRange(0, indexValue);

    }
}
