//using static Linq_Assignment.Grouping;
using Week_4_Task.Utility;
using Week_4_Task.WelcomePage;
using System.Linq;

Welcomepage.Welcome();
Console.Read();

States states = new States();
Market market = new Market();
Marketlist marketlist = new Marketlist();
GRPA gRPA = new GRPA();
GRPB gGRPB = new GRPB();
GRPC gRPC = new GRPC();

// using Method Syntax

Console.WriteLine("\n A Group of states in set of 3\n");
Console.WriteLine("----------------------------------");
var StateGrp = States.GetStates().GroupBy(x => x.stateID);
foreach (var item in StateGrp)
{
    var grps = string.Join(',', item.Select(t => t.stateName));

    Console.WriteLine(grps);
    Console.WriteLine("\nn----------------------------------\nn");
}
Console.Read();

// Join Method
var output = Marketlist.GetMktList().Join(Market.MarketSales(), l => l.ItemId, m => m.itemId, (l, m) => new { 
    Id = l.ItemId,
    Name = l.ItemDes,
    Quantity = m.Qty,
});
Console.WriteLine("\n\n Item ID     Item Name      Quantity");
Console.WriteLine("-------------------------------------");
foreach (var item in output)
{
    Console.WriteLine($"    {item.Id}       {item.Name}             {item.Quantity}");
}

Console.Read();

// GroupJoin Method

var groupJOIN = gGRPB.GRP2().GroupJoin(gRPA.GRP1(), v => v.Id, z => z.stateID, (v, stateGrp) => new
{
    Name = v.groupName,
    state = stateGrp.Select( q => q.stateName)
});
 foreach (var item in groupJOIN)
{
    Console.WriteLine($"\nGroup {item.Name}                 {item.state.Count()}\n");
    Console.WriteLine(string.Join(", ", item.state));
    Console.WriteLine("-----------------------------------");



}
//IEnumerable<IGrouping<int, State>> states = States.GetStates().GroupBy(x => x.Id);

//foreach (IGrouping<string, State> group in states
//{
//    Console.WriteLine(group.Key + ";" + group.Count());

//    foreach (var item in group)
//    {
//        Console.WriteLine(item.stateName);
//    }
//}
  
// Using Query Syntax

//IEnumerable<IGrouping<int, State>> GroupByQS = (from std in States.GetStates() 
//
//                              group std by std.Id);
