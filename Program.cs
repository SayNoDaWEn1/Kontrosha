namespace HelloWorld
{
    class Programm{
        static void Main(string[] args){
            Console.WriteLine("ВВедите длину массива");
            int masLength=Convert.ToInt32(Console.ReadLine());
            string [] mas=new string[masLength];
            for(int i=0; i<mas.Length; i++){
                Console.WriteLine($"ВВедите {i} элемент массива ");
                mas[i]=Convert.ToString(Console.ReadLine());
            }
            string [] masAnswer=new string[mas.Length];
            int m=0;
            for(int i=0; i<mas.Length; i++){
                if (mas[i].Length<3){
                masAnswer[m]=mas[i];
                m++;
                }
            }
            Console.WriteLine("Новый массив сформирован, его результат будет выведен на экран :");
            for(int i=0; i<masAnswer.Length ; i++){
                if(masAnswer[i]!=null){
                Console.WriteLine(masAnswer[i]);
                }else{break;}
                
            }
            Console.WriteLine("Программа завершила свою работу");


            
        }
    }
}