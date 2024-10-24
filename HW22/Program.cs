using System.ComponentModel.DataAnnotations;

Console.Write("Please enter the first sentence: ");
string A = Console.ReadLine();
string a = A.Replace(" ", "");
Console.Write("Please enter the second sentence: ");
string B = Console.ReadLine();
string b = B.Replace(" ", "");
int lena = a.Length;
int lenb = b.Length;
string[] common = new string[lena*lenb];
string dif1 = "";
string dif2 = "";
int c = 0;
int d = 0;
int z = 0;
for (int i = 0; i < a.Length; i++)
{
    for (int j = 0; j < b.Length && i < a.Length; j++)
    {
        if (a[i] == b[j])
        {
            common[c] += b[j];   
            i++;
        }
        else if (a[i] != b[j])

        {
            
            dif2 += b[j];
            dif1 += a[i];
            common[c] +="";
            c++;
            i = z;
        }
    }
    z++;
}
string[] common2 = new string[c];
string C = "";
int count= 0;   
foreach(string s in common) 
{
    common2[count] = s;
    count++;
    if (count == common2.Length)
    { break; }
}
int max = common2[0].Length;
foreach(string st in common2)
{
    if( st.Length >= max )
    {
        max = st.Length;
         C = st;
    }
}
Console.WriteLine($"The largest these two sentences have in common is {C} ");
//int index = 0;
//bool same = true;
//int index2 = 0;
//while(same)
//{
//    if ( a[index] == b[index])
//    {
//        common[index2] += a[index];
//        index++;
//    }
//    if (index == a.Length && index == b.Length)
//    {
//        same = false;
//    }
//    else if ( a[index] != b[index])
//    {
//        dif1 += a[index];
//        dif2 += b[index];
//        index2++;
//        index++;
//    }

//}
//int max =0;
//foreach(string st in common)
//{
//    if( st.Length > max )
//    {

//    }
//}
