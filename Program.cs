const int N = 5;
string[] s = new string[N] {"hello", 
                            "123",
                            "world", 
                            ":)",
                            "45"};

int count = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i].ToCharArray().Length <= 3)
    {
        count++;
    }
}      

string[] new_s = new string[count];
int current_index = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i].ToCharArray().Length <= 3)
    {
        new_s[current_index] = s[i];
        current_index++;
    }
}