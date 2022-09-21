namespace IntroductionToCSharp.Demo
{
    /// <summary>
    /// An enum is an enumeration (list) of symbols which
    /// can be used as a data type
    /// </summary>
    public enum PlayerType : sbyte  //store as 8-bit with range 0 - 255
    {
        //int value we assign will determine the Asc/Desc sort order
        Mage = 2,

        Hunter = 3,
        Assassin = 1,
        Thief = 4
    }
}