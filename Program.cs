
using LinkedListPracticeProblem;

LinkedLists linkedLists = new LinkedLists();

linkedLists.AddNode(56);
linkedLists.AddNode(30);
linkedLists.AddNode(70);
   
linkedLists.AppendNode(56);
linkedLists.AppendNode(30);
linkedLists.AppendNode(40);
linkedLists.AppendNode(70);
linkedLists.sort();
linkedLists.Display();