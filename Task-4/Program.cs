using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayofWeek();
            LifeDays();
            NowPlusDay();
            Yoxla();
            BoyukReqemiTap();
            GunleriTap();
            Math();
        }

        static void DayofWeek()
        {
            Console.WriteLine("Doghum ilinizi daxil edin");
            int doghumIli = int.Parse(Console.ReadLine());
            Console.WriteLine("Doghum ayinizi daxil edin");
            int doghumAyi = int.Parse(Console.ReadLine());
            Console.WriteLine("Doghum gununuzu daxil edin");
            int doghumGunu = int.Parse(Console.ReadLine());

            DateTime dogumTarixi = new DateTime(doghumIli, doghumAyi, doghumGunu);
            Console.Clear();

            Console.WriteLine($"Doghum gununuz {dogumTarixi.DayOfWeek}-dir");
        }

        static void LifeDays()
        {
            Console.WriteLine("Doghum ilinizi daxil edin");
            int doghumIli = int.Parse(Console.ReadLine());
            Console.WriteLine("Doghum ayinizi daxil edin");
            int doghumAyi = int.Parse(Console.ReadLine());
            Console.WriteLine("Doghum gununuzu daxil edin");
            int doghumGunu = int.Parse(Console.ReadLine());

            DateTime dogumTarixi = new DateTime(doghumIli, doghumAyi, doghumGunu);
            DateTime indikiTarix = DateTime.Now;
            TimeSpan span = indikiTarix.Subtract(dogumTarixi);
            Console.WriteLine($" Yashadighiniz gun sayi : {span.TotalDays}");
        }

        static void NowPlusDay()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Elave etmek istediyiniz gun sayini daxil edin : ");
            dateTime = dateTime.AddDays(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"Hesablamaq istediyiniz gun : {dateTime}");
            
        }

        static void Yoxla()
        {
            Console.WriteLine("Ili daxil edin");
            int il = int.Parse(Console.ReadLine());
            Console.WriteLine("Ayi daxil edin");
            int ay = int.Parse(Console.ReadLine());
            Console.WriteLine("Gunu daxil edin");
            int gun = int.Parse(Console.ReadLine());

            Console.WriteLine($"Daxil edilen tarix  {gun}-{ay}-{il}");

            if (il>2022 || il<0)
            {
                Console.WriteLine("Daxil edilen il sehvdir");
            }
            if (ay<=0||ay>12)
            {
                Console.WriteLine("Daxil edilen ay sehvdir");
            }
            if (gun<0 || gun>31)
            {
                Console.WriteLine("Daxil edilen gun sehvdir");
            }
        }

        static void BoyukReqemiTap()
        {
           
            int[] reqemler = new int[3];
            Console.WriteLine("Birinci reqemi daxil edin");
            reqemler[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Birinci reqemi daxil edin");
            reqemler[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Birinci reqemi daxil edin");
            reqemler[2] = int.Parse(Console.ReadLine());

            int enBoyuk = reqemler[0];
            int enKichik = reqemler[0];

            for (int i = 0; i < reqemler.Length; i++)
            {
                if (reqemler[i] > enBoyuk)
                    enBoyuk = reqemler[i];

                if (reqemler[i] < enKichik)
                    enKichik = reqemler[i];

            }

            Console.WriteLine($"En boyuk reqem {enBoyuk}");
            Console.WriteLine($"En boyuk reqem {enKichik}");

        }

        static void GunleriTap()
        {

           
            int girilenReqem = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1-den 7-e qeder bir reqem daxil edin");
                girilenReqem = int.Parse(Console.ReadLine());
            } 
            while (girilenReqem<1 || girilenReqem>7);


            if (girilenReqem==1)
            {
                Console.WriteLine("Monday");
            }
            else if (girilenReqem==2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (girilenReqem==3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (girilenReqem==4)
            {
                Console.WriteLine("Thursday");
            }
            else if (girilenReqem==5)
            {
                Console.WriteLine("Friday");
            }
            else if (girilenReqem==6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Sunday");
            }
                           
        }

        static void Math()
        {
            Console.WriteLine("Birinci reqemi sechin");
            int birReq = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ikinci reqemi sechin");
            int ikiReq = Convert.ToInt32(Console.ReadLine());

            int secilenReqem = 0;

            do
            {
               Console.Clear();
                Console.WriteLine("Istediyiniz riyazi emelin reqemini sechin sechin");
                Console.WriteLine("Toplama - 1");
                Console.WriteLine("Chixma - 2");
                Console.WriteLine("Vurma - 3");
                Console.WriteLine("Bolme - 4");
                Console.WriteLine("Exit -5");
                secilenReqem = Convert.ToInt32(Console.ReadLine());

                if (secilenReqem==1)
                {
                    int top = birReq+ikiReq;
                    Console.WriteLine($"Bu ededlerin Toplami : {birReq}+{ikiReq}={top}");
                }
                else if (secilenReqem==2)
                {
                    int chix = birReq-ikiReq;
                    Console.WriteLine($"Bu ededlerin Ferqi : {birReq}-{ikiReq}={chix}");
                }
                else if (secilenReqem==3)
                {
                    int vur = birReq*ikiReq;
                    Console.WriteLine($"Bu ededlerin Hasili : {birReq}*{ikiReq}={vur}");
                }
                else if (secilenReqem==4)
                {
                    int bol = birReq/ikiReq;
                    Console.WriteLine($"Bu ededlerin Qismeti : {birReq}/{ikiReq}={bol}");
                }
                else if (secilenReqem==5)
                {
                    Console.Clear();
                    Console.WriteLine("Chixish edilir. Teshekkur edirik");
                }
            } 
            while (secilenReqem<1 || secilenReqem>5);

            
            
        }
   
    }
}
