
int [] x = { 1,3,4};

test(x);

for (int i = 0; i < x.Length; i++)
{
    Console.Write(x[i] + " ");
}

static void test(int [] y)
{

    y[1] = 6;
}
