namespace GD.Demo
{
    /// <summary>
    /// Demo - how we can use inheritance rather than composition to
    /// add functionality to existing List class in C#
    /// </summary>
    public class PlayerListInheritance : List<Player>
    {
        //since I inherit I dont need to add list variable, or Add, FindAll etc

        /// <summary>
        /// This method "improves" on the List::Add method by giving us the ability
        /// to say whether we want to add duplicates, or not
        /// </summary>
        /// <param name="p"></param>
        /// <param name="addDuplicate"></param>
        /// <returns></returns>

        public override string ToString()
        {
            int index = 0;
            string outStr = "Name\tHealth\tType";
            foreach (Player p in this)
            {
                outStr += $"[{index}]: {p}";
                index++;
            }

            return outStr;

            //this code would call List::ToString
            //return base.ToString();
        }
    }
}