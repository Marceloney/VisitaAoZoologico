/*
OBJETIVO: Coordenar visitas ao zoologico de diferentes escolas
O aplicativo ajuda a planejar as visitas escolares, dividindo os alunos em grupos e atribuindo a eles um conjunto de animais para visitar.
O código usará métodos para planejar a visita de três escolas, randomizará a ordem dos animais, atribuirá alunos aos grupos e exibirá os resultados.
Você usará métodos que aceitam parâmetros e valores retornados e também incluirá alguns parâmetros opcionais.
*/

/*
Usar métodos para executar tarefas específicas
Criar métodos que aceitam parâmetros obrigatórios e opcionais
Usar valores retornados dos métodos
*/

/*
    - There will be three visiting schools
    - School A has six visiting groups (the default number)
    - School B has three visiting groups
    - School C has two visiting groups

    - For each visiting school, perform the following tasks
    - Randomize the animals
    - Assign the animals to the correct number of groups
    - Print the school name
    - Print the animal groups

*/

using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("SCHOOL A");
PlanSchoolVisit("SCHOOL B", 3);
PlanSchoolVisit("SCHOOL C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
    Console.WriteLine();
}


void RandomizeAnimals()
{
    //embaralhar uma matriz
    Random random = new Random();

    int i = 0;
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
}

string[,] AssignGroup(int groups = 6)
{
    //atribui os animais a grupos
    string[,] result = new string[groups, pettingZoo.Length / groups];

    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;

}

void PrintGroup(string[,] group)
{
    //exibe os resultados dos grupos animais
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]}  ");
        }
        Console.WriteLine();
    }

}