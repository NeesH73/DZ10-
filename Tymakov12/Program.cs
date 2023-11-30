using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("УПР. 12.2: Создать класс рациональных чисел и определить операторы");

            RationalNumber first = new RationalNumber(3, 5);
            RationalNumber second = new RationalNumber(2, 8);

            Console.WriteLine($"Сумма: { first.ToString()} + { second.ToString()} = {first + second}");
            Console.WriteLine($"Разность: {first.ToString()}  - {second.ToString()} = {first - second}");
            Console.WriteLine($"Умножение: {first.ToString()} * {second.ToString()} = {first * second}");
            Console.WriteLine($"Деление: {first.ToString()} / {second.ToString()} = {first / second}");
            Console.WriteLine($"Деление с остатком: {first.ToString()} % {second.ToString()} = {first % second}");
            Console.WriteLine($"++: {first.ToString()} = {++first}");
            Console.WriteLine($"--:{second.ToString()} = {--second}");
            Console.WriteLine($"Больше: {first.ToString()} > {second.ToString()} => {first > second}");
            Console.WriteLine($"Меньше: {first.ToString()} < {second.ToString()} => {first < second}");
            Console.WriteLine($"Больше или равно: {first.ToString()} >= {second.ToString()} => {first >= second}");
            Console.WriteLine($"Меньше или равно:  {first.ToString()} <= {second.ToString()}  => {first <= second}");
            Console.WriteLine($"Приведение типов в float: {second.ToString()} => {(float)second}");
            Console.WriteLine($"Приведение типов в int: {first.ToString()} => {(int)first}");



            Console.WriteLine("Д/З 12.1: Описать класс комплексных чисел и определить операторы");

            Complex firstс = new Complex(3, 5);
            Complex secondс = new Complex(4, 6);

            Console.WriteLine($"Сумма: {firstс.ToString()} + {secondс.ToString()} = {firstс + secondс}");
            Console.WriteLine($"Разность: {firstс.ToString()} - {secondс.ToString()} = {firstс - secondс}");
            Console.WriteLine($"Умножение: {firstс.ToString()} * {secondс.ToString()} = {firstс * secondс}");
            Console.WriteLine($"Равно: {firstс.ToString()} == {secondс.ToString()} => {firstс == secondс}");
            Console.WriteLine($"Неравно: {firstс.ToString()} == {secondс.ToString()} => {firstс != secondс}");
        }
    }
}
