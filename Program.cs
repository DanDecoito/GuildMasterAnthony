using System.Linq;
Console.WriteLine("Hello, World!");
string[] healers = new string[]
{
    "jack", 
    "jim",
    "cory",
    "nick",
    "bill-bl"
};
string[] tanks = new string[]
{
    "Dan",
    "jeff",
    "steve",
    "al",
    "ricky",
    "bobby",
    "jimmy",
    "pedro"
};

string[] dpss = new string[]
{
    "Dan",
    "jeff",
    "steve",
    "al",
    "ricky",
    "bobby",
    "jimmy",
    "pedro",
    "jack",
    "jim",
    "cory",
    "nick",
    "bill",
    "hank",
    "dale",
    ""
};

List<string> tankList = tanks.ToList();
List<string> healerList = healers.ToList();
List<string> dpsList = dpss.ToList();

tanks.ContainS(-bl)

Random rndm = new Random();
tanks = tanks.OrderBy(x => rndm.Next()).ToArray();
dpss = dpss.OrderBy(x => rndm.Next()).ToArray();





int teamNum = 0;
int dpsNum = 0;
foreach (string healer in healers)
{   
    Console.WriteLine($"Team {teamNum}\n   Healer: {healer}\n   Tank:{tanks[teamNum]}\n   Dps1:{dpss[dpsNum + 1]}\n   Dps2:{dpss[dpsNum + 2]}\n   Dps3:{dpss[dpsNum + 3]}");
    dpsNum = dpsNum + 3;
    teamNum++;
}