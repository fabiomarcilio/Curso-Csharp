using System;

namespace Matriz {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o primeiro valor da Matriz: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Entre com o primeiro valor da Matriz: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++) {
                Console.WriteLine("Entre com os valores da matriz: ");
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }


            for (int i = 0; i < l; i++) {
                Console.WriteLine();
                for (int j = 0; j < c; j++) {
                    Console.Write(mat[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite o valor a ser pesquisado: ");
            int valor = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < l; i++) {
                
                Console.WriteLine();
                for (int j = 0; j < c; j++) {
                    count = j;
                    int result = mat[i, j];
                    if (result == valor) {
                        Console.WriteLine("Position: " + i + "," + j + ":");

                        if (j == 0 || i == 0) {
                            count = count + 1;
                            int right = mat[i, count];    
                            Console.WriteLine("Right: " + right);
                            
                            int down = mat[j, count];
                            Console.WriteLine("Down: "+down);

                        }else if (j == c - 1) {
                            count = count - 1;
                            int left = mat[i, count];
                            Console.WriteLine("Left: " + left);
                        }
                        else if (j < c || i < l ) {
                            count = count + 1;
                            int right = mat[i, count];
                            Console.WriteLine("Right: " + right);
                            

                            count = count - 2;
                            int left = mat[i, count];
                            Console.WriteLine("Left: " + left);

                            count = count + 1;
                            int down = mat[j, count];
                            Console.WriteLine("Down: " + down);

                        }
                        else {
                            count = count - 2;
                            int left = mat[i, count];
                            Console.WriteLine("Left: " + left);

                        }

                    }
                }
            }

        }
    }
}
