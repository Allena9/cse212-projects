public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> temp = new();
        int l1Counter = 0;
        int l2Counter = 0;
        for(int i = 0; i < select.Count(); i++)
        {
            if(select[i] == 1)
            {
                temp.Add(list1[l1Counter++]);
            }
            else if(select[i] == 2)
            {
                temp.Add(list2[l2Counter++]);
            }
        }

        return temp.ToArray();
    }
}