// daraja xisoblash
Console.WriteLine("Daraja xisoblash");
Console.Write("Sonni kiriting : ");
int son = Convert.ToInt32(Console.ReadLine());
Console.Write("Darajani kiriting : ");
int daraja = Convert.ToInt32(Console.ReadLine());
int summ=1;
for(int i=0;i<daraja;i++){
    summ=summ*son;
}

Console.Write($"{son} sonining {daraja} - darajasi: {summ}");