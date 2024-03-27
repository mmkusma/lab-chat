using System.Collections.Concurrent;
using Lab.ChatService.Models;

namespace Lab.ChatService.DataService;

public class SharedDb
{
    private ConcurrentDictionary<string, UserConnection> _connections = new();

    public ConcurrentDictionary<string, UserConnection> Connections => _connections;

    public void AddConnection(string connectionId, UserConnection conn)
    {
        _connections.TryAdd(connectionId, conn);
    }
}
