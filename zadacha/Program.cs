// Даны пять целых чисел. Выяснить, что три из них равны пяти, больше трёх из них равны пяти менее трёх из них равны пяти
int [] array = {5,2,5,5,5};
int count = 0;
for ( int i = 0; i < array.Length; i++)
{
    if (array[i] == 5)
        count ++;
}
if (count == 3) 
   Console.WriteLine($"три из чисел равны пяти");
else if (count > 3)
   Console.WriteLine($"Больше трех чисел равны 5");
else
   Console.WriteLine($"Менее трехчисел равны 5");
   
