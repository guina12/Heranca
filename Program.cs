namespace ConsoleApp17.Classes { 
    class WorSpace
    {
        static void Main(string[] args)

            
        {

            int i = 0;
            int control_ = 1;

            while (control_ > 0)
            {




                Console.WriteLine("------- EMPRESA ---------");
                Console.WriteLine("");
                Console.WriteLine("1-Gerente ");
                Console.WriteLine("2-Operador ");
                Console.WriteLine("3-Supervisor ");
                Console.Write("Escolha uma opção :");
                int option = int.Parse(Console.ReadLine());


                switch (option)
                {




                    case 1:



                        Console.WriteLine("Olá gerente:");
                        Console.Write("Nome:");
                        string Nome_ger = Console.ReadLine();
                        Console.Write("Sexo:");
                        string Sex_ger = Console.ReadLine();
                        Console.Write("Senha:");
                        string Pass_ger = Console.ReadLine();
                        Console.Write("CPF:");
                        string CPF_ger = Console.ReadLine();
                        Console.Write("Digite a idade separado por espaço:");
                        string[] age_ger = Console.ReadLine().Split(' ');
                        int year_ger = Convert.ToInt32(age_ger[0]);
                        int month_ger = Convert.ToInt32(age_ger[1]);
                        int day_ger = Convert.ToInt32(age_ger[2]);

                   Pessoas[] pessoas = new Pessoas[] {
                    new Gerente
                     {
                        Nome = Nome_ger,
                        Sexo = Sex_ger,
                        Senha_ger = Pass_ger,
                        CPF=CPF_ger,
                        Data = new DateTime(year: year_ger, month: month_ger, day: day_ger)

                     }
                    };


                        Console.WriteLine();
                        Console.WriteLine("----- Impressão Gerente --------");
                        Console.WriteLine();
                        for (i = 0; i < pessoas.Length; i++)
                        {
                            if (pessoas[i] != null)
                            {
                                Console.WriteLine($"Nome:Gerente {pessoas[i].Nome.ToUpper()}");
                                Console.WriteLine();
                                Console.WriteLine($"Sexo:{pessoas[i].Sexo.ToUpper().Trim()}");
                                Console.WriteLine();
                                Console.WriteLine($"Data: {pessoas[i].Data.ToLongDateString()}");
                                Console.WriteLine();
                                Console.WriteLine($"CPF:{pessoas[i].CPF}");
                               


                            }
                        }
                        break;

                    case 2:

                        Console.WriteLine("Olá Operador:");
                        Console.Write("Nome:");
                        string Nome_op = Console.ReadLine();
                        Console.Write("Sexo:");
                        string Sex_op = Console.ReadLine();
                        Console.Write("Senha:");
                        string Pass_op = Console.ReadLine();
                        Console.WriteLine("CPF:");
                        string CPF_op = Console.ReadLine();
                        Console.Write("Digite a idade separado por espaço:");
                        string[] age_op = Console.ReadLine().Split(' ');
                        int year_op = Convert.ToInt32(age_op[0]);
                        int month_op = Convert.ToInt32(age_op[1]);
                        int day_op = Convert.ToInt32(age_op[2]);

                  Pessoas[] pessos_1 = new Pessoas[] {
                    new Operador
                    {
                        Nome = Nome_op,
                        Sexo = Sex_op,
                        CPF=CPF_op,
                        Senha_op = Pass_op,
                        Data = new DateTime(year: year_op, month: month_op, day: day_op)





                    }
                 };
                        Console.WriteLine();
                        Console.WriteLine("------ Impressão Operador ---------");
                        Console.WriteLine();

                        i = 0;

                        while (i < pessos_1.Length)
                        {
                            if (pessos_1[i] != null)
                            {
                                Console.WriteLine($"Nome Operador {pessos_1[i].Nome.ToUpper().Trim()}");
                                Console.WriteLine();
                                Console.WriteLine($"Sexo:{pessos_1[i].Sexo.ToUpper().Trim()}");
                                Console.WriteLine();
                                Console.WriteLine($"Data: {pessos_1[i].Data.ToLongDateString()}");
                                Console.WriteLine();
                                Console.WriteLine($"CPF:{pessos_1[i].CPF}");
                                i++;
                                Console.WriteLine();

                            }

                        }


                        break;

                    case 3:

                        Console.WriteLine("Olá Supervisor:");
                        Console.Write("Nome:");
                        string Nome_sup = Console.ReadLine();
                        Console.Write("Sexo:");
                        string Sex_sup = Console.ReadLine();
                        Console.Write("Senha:");
                        string Pass_sup = Console.ReadLine();
                        Console.Write("CPF:");
                        string CPF_sup = Console.ReadLine();
                        Console.Write("Digite a idade separado por espaço:");
                        string[] age_sup = Console.ReadLine().Split(' ');
                        int year_sup = Convert.ToInt32(age_sup[0]);
                        int month_sup = Convert.ToInt32(age_sup[1]);
                        int day_sup = Convert.ToInt32(age_sup[2]);


                  Pessoas[] pessoas_3 = new Pessoas[] {
                    new SuperVisor
                    {
                        Nome = Nome_sup,
                        Sexo = Sex_sup,
                        CPF=CPF_sup,
                        Senha_super = Pass_sup,
                        Data = new DateTime(year: year_sup, month: month_sup, day: day_sup)

                    }
                   };

                        Console.WriteLine();
                        Console.WriteLine("------- Impressão Supervisor --------");
                        Console.WriteLine();
                        foreach (Pessoas item in pessoas_3)
                        {
                            if (item != null)
                            {
                                Console.WriteLine($"Nome Supervisor {item.Nome.ToUpper().Trim()}");
                                Console.WriteLine();
                                Console.WriteLine($"Sexo:{item.Sexo.ToUpper().Trim()}");
                                Console.WriteLine();
                                Console.WriteLine($"Data: {item.Data.ToLongDateString()}");
                                Console.WriteLine();
                                Console.WriteLine($"CPF:{item.CPF}");
                                Console.WriteLine();

                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Opção Invalida:");
                        break;


                }


                Console.WriteLine();
                Console.Write("Deseja Continuar ?[S/N]:");
                char op = char.Parse(Console.ReadLine());
                int x = (op == 'S' || op == 's') ? control_++ : control_-100;
                control_ = x;
               


            }

        }
    }
}