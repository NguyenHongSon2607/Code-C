using System;

class Bai3 {
    static void Main() {
        for (int n = 0; n <= 7; n++) {
            // in gia tri cua n
            Console.Write($"n = {n}: ");

            // vong lap ben trong chay tu k = 0 den k = n
            for (int k = 0; k <= n; k++)
            {
                // tinh he so nhi thuc (n chon k)
                int coefficient = BinomialCoefficient(n, k);
                Console.Write(coefficient + " ");
            }
            Console.WriteLine();
        }
    }

    private static int BinomialCoefficient(int n, int k) {
        int result = 1;

        for (int i = 1; i <= k; i++) {
            result *= (n - i + 1);
            //  tuong duong voi result = result * (n - i + 1)
            result /= i;
            //  tuong duong voi : result = result / i
        }
        return result;
    }
}