// Elvis operators add extra CC per instance
namespace CyclomaticComplexity
{
    // CC = 1
    public class ElvisOperator
    {
        // CC = 1
        public string Process(Position position)
        {
            var at = ((Top)position)?.Middle?.Bottom ?? Position.Default;

            return at.ToString();
        }
    }

    public abstract class Position
    {
        public static Position Default = new Empty();
    }
    internal class Empty : Position
    {
        public override string ToString()
        {
            return "Empty";
        }
    }
    public class Top : Position
    {
        public Top()
        {
            Middle = null;
        }

        public Middle Middle { get; set; }

        public override string ToString()
        {
            return "Top";
        }
    }
    public class Middle : Position
    {
        public Middle()
        {
            Bottom = null;
        }

        public Bottom Bottom { get; set; }

        public override string ToString()
        {
            return "Middle";
        }
    }
    public class Bottom : Position
    {
        public Bottom()
        {
        }
        public override string ToString()
        {
            return "Bottom";
        }
    }
}
