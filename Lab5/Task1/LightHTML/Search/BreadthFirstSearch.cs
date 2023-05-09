using Task1.LightHTML.Elements;

namespace Task1.LightHTML.Search;

public class BreadthFirstSearch : ISearchStrategy
{
    public bool Search(LightNode node, Func<LightNode, bool> predicate)
    {
        if (node == null) return false;

        var queue = new Queue<LightNode>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (predicate(current)) return true;

            if (current is LightElementNode elementNode)
            {
                foreach (var child in elementNode.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        return false;
    }

    public IEnumerable<LightElementNode> FindAll(LightNode node, Func<LightElementNode, bool> predicate)
    {
        var result = new List<LightElementNode>();

        if (node == null) return result;

        var queue = new Queue<LightNode>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current is LightElementNode elementNode && predicate(elementNode))
            {
                result.Add(elementNode);
            }

            if (current is LightElementNode childElementNode)
            {
                foreach (var child in childElementNode.Children)
                {
                    queue.Enqueue(child);
                }
            }
        }

        return result;
    }
}