Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Rolar de Dados: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    if((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("Você tirou triplo acerto! Sera adcionado  mais +6 pontos!");
        total += 6;
    }

    else{
        Console.WriteLine("Você tirou duplo acerto! Serão adcionado mais +3 pontos!");
        total += 3;
    }
}

if (total >= 15){
    Console.WriteLine("Você venceu!!");
}

else if (total <= 14) {
    Console.WriteLine("Você conseguiu um carro!!");
}

else if (total > 10) {
    Console.WriteLine("Você consegui um Notbook Game!!");
}

else if (total == 8) {
    Console.WriteLine("Você conseguir uma viagem só  de ida para qualquer lugar!");
}

else if (total <= 7) {
    Console.WriteLine("Você consegui um aperto de mão");
}

Console.ReadKey();