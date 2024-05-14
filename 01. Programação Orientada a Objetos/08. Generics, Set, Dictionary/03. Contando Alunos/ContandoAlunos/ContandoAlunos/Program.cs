namespace ContandoAlunos {
    internal class Program {
        static void Main(string[] args) {

            HashSet<int> alunosPorMatricula = new HashSet<int>();

            string[] cursos = { "A", "B", "C" };

            foreach (string curso in cursos) {
                Console.Write($"Quanto alunos para o curso {curso}? ");
                int quantidadeAlunos = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantidadeAlunos; i++) {
                    int matricula = int.Parse(Console.ReadLine());
                    alunosPorMatricula.Add(matricula);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Total de estudantes: {alunosPorMatricula.Count()}");
        }
    }
}