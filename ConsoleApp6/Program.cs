// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dammi una parola");
string parola=Console.ReadLine();
Console.WriteLine("dammi k1");
int k1=Int32.Parse(Console.ReadLine());
Console.WriteLine("dammi k2");
int k2 = Int32.Parse(Console.ReadLine());

string sostituzione(string parola,int chiave)
{
    char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i','j' ,'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w','x','y','z' };
    string ris = "";
    for(int i = 0; i < parola.Length; i++)
    {
        for(int j = 0; j < arr.Length; j++)
        {
            if (parola[i] == arr[j])
            {
                
                
                if (j+chiave >= arr.Length-1 )
                {
                  
                    ris += arr[0 + chiave-(26-j)];
                }
                else
                {
                    ris += arr[j + chiave];
                }
                
            }
        }
    }
    return ris;
}
Console.WriteLine(sostituzione(parola,k1));

