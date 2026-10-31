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
        // 1. Create a doble array of size 'length'.
        // 2. Loop form 1 = 0 up to length - 1.
        // 3. Multiply 'number' by (i + 1) to get each sequential multiple.
        // 4. Store the calculated multiple at index i in the array.
        // 5. return the completed array.
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
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
        // 1. Check if the list is null, empty, or if amount is less tham or equal to 0, and exit if so.
        // 2. Use the modulo operator (amount % data.Count) to handle rotation amounts larger than the list size.
        // 3. Extract the tail portion of the list that needs to move to the front using GetRange.
        // 4. Extract the remaing head portion of the list using GetRange.
        // 5. Clear The original list and re-add the tail elements followed by the head elements.
        
        if (data == null || data.Count == 0 || amount <= 0)
            return;

        amount = amount % data.Count;
        if (amount == 0)
            return;

        List<int> tail = data.GetRange(data.Count - amount, amount);
        List<int> head = data.GetRange(0, data.Count - amount);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
