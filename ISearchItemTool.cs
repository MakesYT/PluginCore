namespace PluginCore;

public interface ISearchItemTool
{
    void OpenFile(SearchViewItem? item);

    void IgnoreItem(SearchViewItem? item);

    void OpenFolder(SearchViewItem? item);

    void RunAsAdmin(SearchViewItem? item);

    void Star(SearchViewItem? item);

    void Pin(SearchViewItem? item);

    void OpenFolderInTerminal(SearchViewItem? item);

    void OpenSearchItemByOnlyKey(string onlyKey);
}