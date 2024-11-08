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
        // Create a list to hold the multiples and 'multiple' to keep track of the current multiple
        List<double> multiples = new();
        double multiple = 0;

        // Loop until we have the required number of multiples
        while(multiples.Count() < length)
        {
            // Increment the multiple by the base number and add the current multiple to the list
            multiple += number;
            multiples.Add(multiple);
        }
        // Convert the list of multiples to an array and return it
        return multiples.ToArray();
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
        // Create a new list to hold the elements that will be rotated to the front
        List<int> l1 = new();
        // Get the last 'amount' elements from the original list
        l1 = data.GetRange(data.Count - amount, amount);
        // Remove the last 'amount' elements from the original list and insert the elements from l1 at the beginning of the original list
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, l1);
        


    }
}
