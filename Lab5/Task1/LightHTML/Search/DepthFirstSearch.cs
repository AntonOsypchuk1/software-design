using Task1.LightHTML.Elements;

namespace Task1.LightHTML.Search;

public class DepthFirstSearch : ISearchStrategy
{
    public bool Search(LightNode node, Func<LightNode, bool> predicate)
    {
        if (node == null) return false;

        if (predicate(node)) return true;

        if (node is LightElementNode elementNode)
        {
            foreach (var child in elementNode.Children)
            {
                if (Search(child, predicate)) return true;
            }
        }

        return false;
    }

    public IEnumerable<LightElementNode> FindAll(LightNode node, Func<LightElementNode, bool> predicate)
    {
        if (node is LightElementNode elementNode)
        {
            if (predicate(elementNode))
            {
                yield return elementNode;
            }

            foreach (var child in elementNode.Children)
            {
                foreach (var match in FindAll(child, predicate))
                {
                    yield return match;
                }
            }
        }
    }
}