namespace ContandoAlunos {
    internal class Program {
        static void Main(string[] args) {

            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();            

            string[] cursos = { "A", "B", "C" };

            foreach (string curso in cursos) {
                Console.Write($"Quanto alunos para o curso {curso}? ");
                int quantidadeAlunos = int.Parse(Console.ReadLine());

                if (curso == "A") {
                    for (int i = 1; i <= quantidadeAlunos; i++) {
                        int matricula = int.Parse(Console.ReadLine());
                        cursoA.Add(matricula);
                    }
                    Console.WriteLine();

                } else if (curso == "B") {
                    for (int i = 1; i <= quantidadeAlunos; i++) {
                        int matricula = int.Parse(Console.ReadLine());
                        cursoB.Add(matricula);
                    }
                    Console.WriteLine();

                } else if (curso == "C") {
                    for (int i = 1; i <= quantidadeAlunos; i++) {
                        int matricula = int.Parse(Console.ReadLine());
                        cursoC.Add(matricula);
                    }
                    Console.WriteLine();
                }
            }

            HashSet<int> total = new HashSet<int>(cursoA);

            total.UnionWith(cursoB);
            total.UnionWith(cursoC);

            Console.WriteLine($"Total de estudantes: {total.Count()}");
        }
    }
}