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

        // 1. create an array with doubles with the length
        double[] multiples = new double[length];

        // 2. Loop each index of the array from 0 up to the last index.
        for (int i = 0; i < length; i++)
        {
            // 3. Calculate the multiple. 
            multiples[i] = number * (i + 1);
        }

        // 4. Return multiples at this point since it has been updated.
        return multiples;
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Check if amount is 0 or equal to Count. 
        if (data.Count <= 1 || amount == 0 || amount == data.Count)
        {
            return;
        }

        // 2. List to move.
        int startingIndex = data.Count - amount;

        // 3. get the range of values from the end of the list.
        List<int> movedPart = data.GetRange(startingIndex, amount);

        // 4. Remove the values we that is copied from their original position.
        data.RemoveRange(startingIndex, amount);

        // 5. Insert the copied values back at the very beginning (index 0).
        data.InsertRange(0, movedPart);
    }
}
