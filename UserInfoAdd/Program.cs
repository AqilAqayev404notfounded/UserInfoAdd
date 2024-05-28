namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Istifadeci adini daxil edin");
            string userName = "";
            string userSurname = "";
            string FIN = "";
            string fatherName = "";
            string jobPasition = "";
            int salary = 0;
            string phoneNumber = "";


            Console.WriteLine("Ad daxil et");
            while (true)
            {
                Console.WriteLine("ilk herf  boyuk,qalanlari kicik olmalidir.Soyad 2 den boyuk 20  den kicik olmalidir.Daxilinde reqemden istifade olunmamalidir!!!");
                userName = Console.ReadLine();

                if (userName.Length < 2 || userName.Length > 20)
                {
                    Console.WriteLine("Ad 2den boyuk 20 den kicik");

                }

                if (!char.IsUpper(userName[0]))
                {
                    Console.WriteLine("ilk herf boyuk olmalidir");
                    continue;

                }
                else
                {
                    bool k = true;
                    for (int i = 1; i < userName.Length; i++)
                    {
                        if (!char.IsLetter(userName[i]))
                        {
                            k = false;
                            break;
                        }
                        if (!char.IsLower(userName[i]))
                        {
                            k = false;
                            break;
                        }
                    }
                    if (k)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine("soyad daxil et");
            while (true)
            {
                Console.WriteLine("ilk herf  boyuk,qalanlari kicik olmalidir.Soyad 2 den boyuk 35  den kicik olmalidir.Daxilinde reqemden istifade olunmamalidir!!!");
                userSurname = Console.ReadLine();

                if (userSurname.Length < 2 || userSurname.Length > 35)
                {
                    Console.WriteLine("Soyad 2den kicik 35 den boyuk olamlidir");

                }

                if (!char.IsUpper(userSurname[0]))
                {
                    Console.WriteLine("ilk herf boyuk olmalidir");
                    continue;

                }
                else
                {
                    bool k = true;
                    for (int i = 1; i < userSurname.Length; i++)
                    {
                        if (!char.IsLetter(userSurname[i]))
                        {
                            k = false;
                            break;
                        }
                        if (!char.IsLower(userSurname[i]))
                        {
                            k = false;
                            break;
                        }
                    }
                    if (k)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }



            }

            Console.WriteLine("ata adi daxil et");
            while (true)
            {
                Console.WriteLine("ilk herf  boyuk,qalanlari kicik olmalidir.Soyad 2 den boyuk 20  den kicik olmalidir.Daxilinde reqemden istifade olunmamalidir!!!");
                fatherName = Console.ReadLine();

                if (fatherName.Length < 2 || fatherName.Length > 20)
                {
                    Console.WriteLine("Ata adi 2den boyuk 20 den kicik");

                }

                if (!char.IsUpper(fatherName[0]))
                {
                    Console.WriteLine("ilk herf boyuk olmalidir");
                    continue;

                }
                else
                {
                    bool k = true;
                    for (int i = 1; i < fatherName.Length; i++)
                    {
                        if (!char.IsLetter(fatherName[i]))
                        {
                            k = false;
                            break;
                        }
                        if (!char.IsLower(fatherName[i]))
                        {
                            k = false;
                            break;
                        }
                    }
                    if (k)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            while (true)
            {
                finIntroduction();
                Console.WriteLine("FIN NOMRESIN ");
                FIN = Console.ReadLine();

                if (FIN.Length < 6 || FIN.Length > 8)
                {


                    continue;
                }
                bool k = true;
                for (int i = 0; i < FIN.Length; i++)
                {

                    if (!char.IsUpper(FIN[i]) && char.IsLetter(FIN[i]))
                    {
                        k = false;
                        break;

                    }

                }
                if (k)
                {
                    break;
                }
                else
                {


                    continue;
                }


            }
            int userAge = 0;

            while (true)
            {
                Console.WriteLine("Yasivizi girin :");
                string input = Console.ReadLine();


                if (!int.TryParse(input, out userAge))
                {
                    Console.WriteLine("herf daxil etmeyin");
                    continue;
                }


                if (userAge < 18 || userAge > 65)
                {
                    Console.WriteLine("Yas 18 ile 65 arasında olmalıdır.");
                    continue;
                }

                break;

            }
            while (true)
            {
                Console.WriteLine("Islediyiviz pozisyani girin (HR , Audit , Engineer)");
                jobPasition = Console.ReadLine();
                if (jobPasition == "HR" || jobPasition == "Audit" || jobPasition == "Engineer")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("asagdaki pozisyalardan birini girin");
                    continue;
                }

            }
            while (true)
            {
                Console.WriteLine("Maas miqdarini giin.Maas miqdari 1500 ve 5000 arasi olmalidir ,maas miqdarini herflerle ifade etmeyin!!!");

                string input = Console.ReadLine();


                if (!int.TryParse(input, out salary))
                {
                    Console.WriteLine("herf daxil etmeyin");
                    continue;
                }

                if (salary >= 1500 && salary <= 5000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("asagdaki Maas araliqlarindan birini girin");
                }




            }
            while (true)
            {
                Console.WriteLine("Nomrenizi daxil edin.(+994 ile baslanmalidir,umumi uzunlugu 13 beraber olamlidir)");

                phoneNumber = Console.ReadLine();

                if (phoneNumber.Length == 13 && phoneNumber[0] == '+' && phoneNumber[1] == '9' && phoneNumber[2] == '9' && phoneNumber[3] == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("duzgun telefon nomresi daxil edin, asagidaki sertlere uygun telefon nomresi girin.");
                }





            }



            Console.Write($"Adi :{userName} Soyad :{userSurname} Ata adi :{fatherName} FIN nomresi : {FIN} Yasi : {userAge} Position : {jobPasition} Maas : {salary} telefon : {phoneNumber}");
            Console.WriteLine("sisteme  elave olundu");
        }
        public static void finIntroduction()
        {
            Console.WriteLine("Fin nomresi 7 karakterterde (reqem ve herfler) ibaretdir.Herfler yalniz boyuk ola biler");
        }
    }
}
