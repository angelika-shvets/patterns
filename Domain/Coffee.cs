namespace Patterns.Domain;

public class Coffee : ICoffee
{
    private readonly List<object> _compound;

    public Coffee()
    {
        _compound = new List<object>();
    }

    public async Task Add(string part)
    {
        _compound.Add(part);

        await Task.CompletedTask;
    }

    public async Task Reset()
    {
        _compound.Clear();
        await Task.CompletedTask;
    }

    public async Task<string> GetCoffee()
    {
        var compounds = string.Join(",", _compound);

        return await Task.FromResult(compounds);
    }
}