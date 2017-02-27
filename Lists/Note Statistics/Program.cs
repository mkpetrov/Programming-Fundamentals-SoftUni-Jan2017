using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFrequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var notes = "C C# D D# E F F# G G# A A# B"
                .Split()
                .ToList();

            var frequencies = "261.63 277.18 293.66 311.13 329.63 349.23 369.99 392.00 415.30 440.00 466.16 493.88"
                .Split()
                .Select(double.Parse)
                .ToList();

            var result = new List<string>();

            foreach (var frequency in inputFrequencies)
            {
                var frenquencyIndex = frequencies.IndexOf(frequency);
                var note = notes[frenquencyIndex];
                result.Add(note);
            }
            Console.WriteLine("Notes: {0}",string.Join(" ",result));
            var naturals = new List<string>();
            var sharps = new List<string>();

            foreach (var item in result)
            {
                if (item.Length==2)
                {
                    sharps.Add(item);
                }
                else
                {
                    naturals.Add(item);
                }
            }
            Console.WriteLine("Naturals: {0}",string.Join(", ",naturals));
            Console.WriteLine("Sharps: {0}",string.Join(", ",sharps));
            var naturalSum = 0.0;
            var sharpsSum = 0.0;

            foreach (var note in naturals)
            {
                var frequencyIndex = notes.IndexOf(note);
                var frequency = frequencies[frequencyIndex];
                naturalSum += frequency;
            }
            foreach (var note in sharps)
            {
                var frequencyIndex = notes.IndexOf(note);
                var frequency = frequencies[frequencyIndex];
                sharpsSum += frequency;
            }
            Console.WriteLine("Naturals sum: {0}",naturalSum);
            Console.WriteLine("Sharps sum: {0}",sharpsSum);
        }
    }
}
