public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }
        else
        {
            Person person = _people.Dequeue();

            // If turns are 0 or negative (infinite), re-enqueue without changing the turns value.
            if (person.Turns <= 0)
            {
                _people.Enqueue(person);
            }
            // If turns are greater than 1, decrement by one and re-enqueue.
            else if (person.Turns > 1)
            {
                person.Turns -= 1;
                _people.Enqueue(person);
            }
            // If turns are exactly 1, use it up and do NOT re-enqueue.

            return person;
        }
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}