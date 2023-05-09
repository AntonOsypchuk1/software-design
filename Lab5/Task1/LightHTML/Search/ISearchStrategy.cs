using Task1.LightHTML.Elements;

namespace Task1.LightHTML.Search;

public interface ISearchStrategy
{
    bool Search(LightNode node, Func<LightNode, bool> predicate);
    IEnumerable<LightElementNode> FindAll(LightNode node, Func<LightElementNode, bool> predicate);
}