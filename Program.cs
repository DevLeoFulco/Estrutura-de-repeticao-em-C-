int opcao;


while (true){
    
    Console.WriteLine("Digite sua opção");
    Console.WriteLine("Opção 1 para agendar: ");
    Console.WriteLine("Opção 2 para consultar");
    Console.WriteLine("Opção 3 para desmarcar");

    opcao = Convert.ToInt32(Console.ReadLine());

    switch(opcao){

        case 1:
            int dia;
            Console.WriteLine("Agendamento de consultas:");
            Console.WriteLine("Digite para qual dia da semana deseja agendar! Utilize de 1 a 5 para segunda, terça, quarta,quinta ou sexta\n");
            dia = Convert.ToInt32(Console.ReadLine());

            switch(dia){
                case 1:
                    Console.WriteLine("Você agendou para SEGUNDA-FEIRA!\n");
                break;  
                case 2:
                    Console.WriteLine("Você agendou para TERÇA-FEIRA!\n");
                break; 
                case 3:
                    Console.WriteLine("Você agendou para QUARTA-FEIRA!\n");
                break; 
                case 4:
                    Console.WriteLine("Você agendou para QUINTA-FEIRA!\n");
                break; 
                case 5:
                    Console.WriteLine("Você agendou para SEXTA-FEIRA!\n");
                    Environment.Exit(0);
                break;  

                default:
                    Console.WriteLine("Opção Invalida!");
                break;     
            }

        break;    
        
        case 2:
            int dias;
            Console.WriteLine("Seguindo a mesma instrução de uso dos numeros de 1 a 5 para os dias da semana, qual o dia da semana deseja informação:");
            dias = Convert.ToInt32(Console.ReadLine());

                switch(dias){
                    case 1:
                    Console.WriteLine("SEGUNDA-FEIRA DISPONÍVEL!");
                    break;
                    case 2:
                        Console.WriteLine("TERÇA-FEIRA DISPONÍVEL!");
                    break;
                    case 3:
                        Console.WriteLine("DESCULPE! NÃO TEMOS VAGA PARA A QUARTA-FEIRA");
                    break;
                    case 4:
                        Console.WriteLine("QUINTA-FEIRA DISPONÍVEL!");
                    break;
                    case 5:
                        Console.WriteLine("DESCULPE! NÃO TEMOS VAGA PARA A SEXTA-FEIRA");
                    break;
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;    

                }

        break;
        case 3:
            int cancela;
            Console.WriteLine("Seguindo a mesma instrução de uso dos numeros de 1 a 5 para os dias da semana, qual o dia da semana deseja informação:");
            cancela = Convert.ToInt32(Console.ReadLine());

                switch(cancela){
                    case 1:
                    Console.WriteLine("SEGUNDA-FEIRA CONSULTA CANCELADA!");
                    break;
                    case 2:
                        Console.WriteLine("TERÇA-FEIRA CONSULTA CANCELADA!");
                    break;
                    case 3:
                        Console.WriteLine("QUARTA-FEIRA CONSULTA CANCELADA!");
                    break;
                    case 4:
                        Console.WriteLine("QUINTA-FEIRA CONSULTA CANCELADA!!");
                    break;
                    case 5:
                        Console.WriteLine("SEXTA-FEIRA CONSULTA CANCELADA!");
                    break;
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;    

                }

        break;


    }
}



